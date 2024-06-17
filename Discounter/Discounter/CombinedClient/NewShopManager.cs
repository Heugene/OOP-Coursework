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
using Domain;
using System.Net;

namespace CombinedClient
{
    public partial class NewShopManager : Form
    {
        public bool IsFilled { get; private set; } = false;
        public string Name { get; private set; }
        public string Phone { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public Shop ManagedShop { get; private set; }

        DataGridViewRow selectedRow;

        public NewShopManager()
        {
            InitializeComponent();
        }

        private void LoadShopsByTrademark(Trademark trademark)
        {
            // Заповнити датагрід назвами торгових марок

            // Скинути датасурс і колонки датагріду
            dataGridView.DataSource = null;
            dataGridView.Columns.Clear();

            // Вимкнути автогенерацію колонок
            dataGridView.AutoGenerateColumns = false;

            // Дістати список магазинів з бд за торговою маркою
            List<Shop> shops = DAL.ShopController.GetAllShopsByTrademark(trademark);
            // Заповнити датагрід вмістом колекції
            dataGridView.DataSource = shops;

            // Задати вручну стовпець назви
            DataGridViewTextBoxColumn colTrademarkName = new DataGridViewTextBoxColumn();
            colTrademarkName.DataPropertyName = "Trademark.Name";
            colTrademarkName.Name = "TrademarkName";
            dataGridView.Columns.Add(colTrademarkName);

            // Задати вручну стовпець адреси
            DataGridViewTextBoxColumn colShopAddress = new DataGridViewTextBoxColumn();
            colShopAddress.DataPropertyName = "Address";
            colShopAddress.Name = "Address";
            dataGridView.Columns.Add(colShopAddress);

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                row.Cells[dataGridView.ColumnCount - 2].Value = ((Shop)row.DataBoundItem).Trademark.Name;
                row.Cells[dataGridView.ColumnCount - 1].Value = ((Shop)row.DataBoundItem).Address;
            }
        }

        private void NewShopManager_Load(object sender, EventArgs e)
        {
            // заповнити комбобокс торговими марками

            comboBoxTrademark.DisplayMember = "Name";

            comboBoxTrademark.DataSource = DAL.TrademarkController.GetTrademarks();

            comboBoxTrademark.SelectedIndex = 0;
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // Якщо є якийсь селекшн
            if (dataGridView.SelectedRows.Count > 0)
            {
                // розблокувати кнопки
                buttonCreate.Enabled = true;

                // Задати вибраний рядок
                selectedRow = dataGridView.SelectedRows[0];
            }
            // Якщо нема селекшену
            else
            {
                // заблокувати кнопки
                buttonCreate.Enabled = false;
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (
                textBoxName.Text != "" && 
                maskedTextBoxPhone.Text != "" &&
                textBoxEmail.Text != "" &&
                textBoxPassword.Text != "" &&
                selectedRow is not null)
            {
                Name = textBoxName.Text;
                Phone = maskedTextBoxPhone.Text;
                Email = textBoxEmail.Text;
                Password = textBoxPassword.Text;
                ManagedShop = (Shop)selectedRow.DataBoundItem;

                IsFilled = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Не можна створити об'єкт з порожніми полями!", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void comboBoxTrademark_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadShopsByTrademark(comboBoxTrademark.SelectedItem as Trademark);
        }
    }
}
