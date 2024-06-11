using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CombinedClient
{
    public partial class DiscountRequestReview : Form
    {
        List<DiscountRequest> requests;

        DataGridViewRow selectedRow;

        public DiscountRequestReview()
        {
            InitializeComponent();
        }

        private void Refresh()
        {

            // Обнулити датасурс у датагріду
            dataGridView.DataSource = null;
            dataGridView.Columns.Clear();

            // Заповнити колекцію об'єктів, використавши контролер
            requests = DAL.DiscountController.GetUnviewedRequests();

            // Заповнити датагрід з колекції
            dataGridView.DataSource = requests;

            // Замінити вкладені об'єкти назвами
            dataGridView.Columns[dataGridView.ColumnCount - 1].Visible = false;
            dataGridView.Columns[dataGridView.ColumnCount - 2].Visible = false;
            dataGridView.Columns[dataGridView.ColumnCount - 3].Visible = false;
            DataGridViewTextBoxColumn colManagerName = new DataGridViewTextBoxColumn();
            colManagerName.DataPropertyName = "Manager.Name";
            colManagerName.Name = "ManagerName";
            dataGridView.Columns.Add(colManagerName);

            DataGridViewTextBoxColumn colManagerEmail = new DataGridViewTextBoxColumn();
            colManagerEmail.DataPropertyName = "Manager.Email";
            colManagerEmail.Name = "ManagerEmail";
            dataGridView.Columns.Add(colManagerEmail);

            DataGridViewTextBoxColumn colTrademarkName = new DataGridViewTextBoxColumn();
            colTrademarkName.DataPropertyName = "RequestedDiscount.Item.Shop.Trademark.Name";
            colTrademarkName.Name = "Trademark";
            dataGridView.Columns.Add(colTrademarkName);

            DataGridViewTextBoxColumn colShopID = new DataGridViewTextBoxColumn();
            colShopID.DataPropertyName = "RequestedDiscount.Item.Shop.ID";
            colShopID.Name = "ShopID";
            dataGridView.Columns.Add(colShopID);

            DataGridViewTextBoxColumn colDiscountID = new DataGridViewTextBoxColumn();
            colDiscountID.DataPropertyName = "RequestedDiscount.ID;";
            colDiscountID.Name = "DiscountID";
            dataGridView.Columns.Add(colDiscountID);

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                row.Cells[dataGridView.ColumnCount - 5].Value = ((DiscountRequest)row.DataBoundItem).Manager.Name;
                row.Cells[dataGridView.ColumnCount - 4].Value = ((DiscountRequest)row.DataBoundItem).Manager.Email;
                row.Cells[dataGridView.ColumnCount - 3].Value = ((DiscountRequest)row.DataBoundItem).RequestedDiscount.Item.Shop.Trademark.Name;
                row.Cells[dataGridView.ColumnCount - 2].Value = ((DiscountRequest)row.DataBoundItem).RequestedDiscount.Item.Shop.ID;
                row.Cells[dataGridView.ColumnCount - 1].Value = ((DiscountRequest)row.DataBoundItem).RequestedDiscount.ID;
            }
        }

        private void DiscountRequestReview_Load(object sender, EventArgs e)
        {
            // Заповнити даними датагрід
            Refresh();
        }

        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            // Оновити дані датагріду
            Refresh();
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // Якщо є якийсь селекшн
            if (dataGridView.SelectedRows.Count > 0)
            {
                // розблокувати кнопки, які стосуються конкретного рядка
                toolStripButtonApprove.Enabled = true;
                toolStripButtonReject.Enabled = true;
                toolStripButtonApproveAll.Enabled = true;
                toolStripButtonRejectAll.Enabled = true;

                // Задати вибраний рядок
                selectedRow = dataGridView.SelectedRows[0];
            }
            // Якщо нема селекшену
            else
            {
                // заблокувати кнопки, які стосуються конкретного рядка
                toolStripButtonApprove.Enabled = false;
                toolStripButtonReject.Enabled = false;
                toolStripButtonApproveAll.Enabled = false;
                toolStripButtonRejectAll.Enabled = false;
            }
        }

        private void toolStripButtonApprove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви дійсно хочете схвалити обраний запит?", "Підтвердіть дію", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Звернутися до контролера і схвалити заявку
                if (DAL.DiscountController.ApproveDiscountRequest((DiscountRequest)selectedRow.DataBoundItem))
                {
                    // Вивести підтвердження схваленння
                    MessageBox.Show("Заявку успішно схвалено!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                // Якщо спіймали помилку, вивести повідомлення
                else
                {
                    MessageBox.Show("Помилка схвалення запису!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // Оновити датагрід
                Refresh();
            }
        }

        private void toolStripButtonReject_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви дійсно хочете відхилити обраний запит?", "Підтвердіть дію", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Звернутися до контролера і відхилити заявку
                if (DAL.DiscountController.RejectDiscountRequest((DiscountRequest)selectedRow.DataBoundItem))
                {
                    // Вивести підтвердження відхилення
                    MessageBox.Show("Заявку успішно відхилено!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                // Якщо спіймали помилку, вивести повідомлення
                else
                {
                    MessageBox.Show("Помилка відхилення запису!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // Оновити датагрід
                Refresh();
            }
        }

        private void toolStripButtonApproveAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви дійсно хочете схвалити всі представлені запити?", "Підтвердіть дію", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool success = true;
                foreach (DataGridViewRow item in dataGridView.Rows)
                {
                    if (!DAL.DiscountController.ApproveDiscountRequest((DiscountRequest)item.DataBoundItem))
                    {
                        success = false;
                    }
                }

                if (success)
                {
                    MessageBox.Show("Всі заявки схвалено!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Помилка схвалення одного або більше запитів!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                Refresh();
            }
        }

        private void toolStripButtonRejectAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви дійсно хочете відхилити всі представлені запити?", "Підтвердіть дію", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool success = true;
                foreach (DataGridViewRow item in dataGridView.Rows)
                {
                    if (!DAL.DiscountController.RejectDiscountRequest((DiscountRequest)item.DataBoundItem))
                    {
                        success = false;
                    }
                }

                if (success)
                {
                    MessageBox.Show("Всі заявки відхилено!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Помилка схвалення одного або більше запитів!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                Refresh();
            }
        }
    }
}
