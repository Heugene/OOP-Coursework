using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

namespace CombinedClient
{
    public partial class ShopCRUD : Form
    {
        List<Shop> shops;

        DataGridViewRow selectedRow;

        public ShopCRUD()
        {
            InitializeComponent();
        }

        private void Refresh()
        {
            // Обнулити датасурс у датагріду
            dataGridView.DataSource = null;
            dataGridView.Columns.Clear();

            // Заповнити колекцію об'єктів, використавши контролер
            shops = DAL.ShopController.GetAllShops();

            // Заповнити датагрід з колекції
            dataGridView.DataSource = shops;

            // Приховати об'єктний стовпець
            dataGridView.Columns[1].Visible = false;

            // Задати вручну стовпець назви
            DataGridViewTextBoxColumn colTrademarkName = new DataGridViewTextBoxColumn();
            colTrademarkName.DataPropertyName = "Trademark.Name";
            colTrademarkName.Name = "TrademarkName";
            dataGridView.Columns.Add(colTrademarkName);

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                row.Cells[dataGridView.ColumnCount - 1].Value = ((Shop)row.DataBoundItem).Trademark.Name;
            }
        }

        private void ShopCRUD_Load(object sender, EventArgs e)
        {
            // Заповнити даними датагрід
            Refresh();
        }

        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            // Оновити дані датагріду
            Refresh();
        }

        private void toolStripButtonNew_Click(object sender, EventArgs e)
        {
            // Викликати форму створення нового об'єкта
            NewShop form = new NewShop();
            form.ShowDialog();
            if (form.IsFilled)
            {
                try
                {
                    // Викликати метод додавання об'єкта з контролеру.
                    if (DAL.ShopController.CreateShop(form.trademark, form.Address) is not null)
                    {
                        // Якщо гуд, повідомлення
                        MessageBox.Show("Об'єкт успішно створений!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Оновити дані датагріду
                        Refresh();
                    }
                    else
                    {
                        // якщо чомусь не додали
                        MessageBox.Show($"Помилка додавання об'єкта!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    // Якщо помилка валідації
                    MessageBox.Show($"Помилка додавання об'єкта!\nКод помилки: {ex.Message}", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            // Викликати форму для редагування об'єкта
            EditShop form = new EditShop((Shop)selectedRow.DataBoundItem);
            form.ShowDialog();
            if (form.IsFilled)
            {
                try
                {
                    // Викликати метод оновлення об'єкта з контролеру.
                    if (DAL.ShopController.UpdateShop((Shop)selectedRow.DataBoundItem, form.Address))
                    {
                        // Якщо гуд, повідомлення
                        MessageBox.Show("Об'єкт успішно оновлений!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Оновити дані датагріду
                        Refresh();
                    }
                    else
                    {
                        // якщо чомусь не оновили
                        MessageBox.Show($"Помилка оновлення об'єкта!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    // Якщо помилка валідації
                    MessageBox.Show($"Помилка оновлення об'єкта!\nКод помилки: {ex.Message}", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            // Переконатися, що користувач дійсно хоче цього
            if (MessageBox.Show("Ви дійсно хочете видалити обраний запис?", "Підтвердіть операцію", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Звернутися до контролера і видалити запис
                if (DAL.ShopController.DeleteShop((Shop)selectedRow.DataBoundItem))
                {
                    // Вивести підтвердження видаленння
                    MessageBox.Show("Запис успішно видалено!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                // Якщо спіймали помилку, вивести повідомлення
                else
                {
                    MessageBox.Show("Помилка видалення запису!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // Оновити датагрід
                Refresh();
            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // Якщо є якийсь селекшн
            if (dataGridView.SelectedRows.Count > 0)
            {
                // розблокувати кнопки, які стосуються конкретного рядка
                toolStripButtonDelete.Enabled = true;
                toolStripButtonEdit.Enabled = true;

                // Задати вибраний рядок
                selectedRow = dataGridView.SelectedRows[0];
            }
            // Якщо нема селекшену
            else
            {
                // заблокувати кнопки, які стосуються конкретного рядка
                toolStripButtonDelete.Enabled = false;
                toolStripButtonEdit.Enabled = false;
            }
        }
    }
}
