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
    public partial class DiscountCRUD : Form
    {
        List<Discount> discounts;

        ShopManager shopManager;

        DataGridViewRow selectedRow;

        public DiscountCRUD(ShopManager manager)
        {
            this.shopManager = manager;
            InitializeComponent();
        }

        private void Refresh()
        {
            // Обнулити датасурс у датагріду
            dataGridView.DataSource = null;
            dataGridView.Columns.Clear();

            // Заповнити колекцію об'єктів, використавши контролер
            discounts = DAL.DiscountController.GetAllActualDiscountsByTrademark(shopManager.ManagedShop.Trademark);

            // Заповнити датагрід з колекції
            dataGridView.DataSource = discounts;

            // Замінити вкладені об'єкти назвами
            dataGridView.Columns[2].Visible = false;
            DataGridViewTextBoxColumn colItemName = new DataGridViewTextBoxColumn();
            colItemName.DataPropertyName = "Item.Name";
            colItemName.Name = "ItemName";
            dataGridView.Columns.Add(colItemName);

            DataGridViewTextBoxColumn colShopID = new DataGridViewTextBoxColumn();
            colShopID.DataPropertyName = "Item.Shop.ID";
            colShopID.Name = "ShopID";
            dataGridView.Columns.Add(colShopID);

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                row.Cells[dataGridView.ColumnCount - 2].Value = ((Discount)row.DataBoundItem).Item.Name;
                row.Cells[dataGridView.ColumnCount - 1].Value = ((Discount)row.DataBoundItem).Item.Shop.ID;
            }
        }

        private void TrademarkCRUD_Load(object sender, EventArgs e)
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
            // Викликати форму створення нового об'єкта та повернути створений об'єкт сюди

            // Викликати метод додавання об'єкта з контролеру і передати туди новий об'єкт.

            // Якщо гуд, повідомлення

            // У випадку помилки - повідомлення

            // Оновити дані датагріду
            Refresh();
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            // Викликати форму редагування об'єкта та передати обраний об'єкт туди

            // Дістати з форми редагування значення полів введення даних

            // Викликати метод зміни об'єкта з контролеру і передати туди обраний об'єкт та отримані значення з форми редагування.

            // Якщо гуд, повідомлення

            // У випадку помилки - повідомлення

            // Оновити дані датагріду
            Refresh();
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // Якщо є якийсь селекшн
            if (dataGridView.SelectedRows.Count > 0)
            {
                // розблокувати кнопки, які стосуються конкретного рядка
                toolStripButtonEdit.Enabled = true;

                // Задати вибраний рядок
                selectedRow = dataGridView.SelectedRows[0];
            }
            // Якщо нема селекшену
            else
            {
                // заблокувати кнопки, які стосуються конкретного рядка
                toolStripButtonEdit.Enabled = false;
            }
        }
    }
}
