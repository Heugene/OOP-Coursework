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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CombinedClient
{
    public partial class NewDiscount : Form
    {
        public bool IsFilled { get; private set; } = false;
        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal OldPrice { get; private set; }
        public decimal NewPrice { get; private set;}
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public DiscountedItem Item { get; set; }

        DataGridViewRow selectedRow;
        Trademark trademark;

        public NewDiscount(Trademark trademark)
        {
            this.trademark = trademark;
            InitializeComponent();
        }

        private void LoadItemsByTrademark(Trademark trademark)
        {
            // Заповнити датагрід назвами товарів за торговою маркою

            // Скинути датасурс і колонки датагріду
            dataGridView.DataSource = null;
            dataGridView.Columns.Clear();

            // Вимкнути автогенерацію колонок
            dataGridView.AutoGenerateColumns = false;

            // Дістати список товарів з бд за торговою маркою
            List<DiscountedItem> items = DAL.DiscountedItemController.GetAllDiscountedItemsByTrademark(trademark);
            // Заповнити датагрід вмістом колекції
            dataGridView.DataSource = items;

            // Задати вручну стовпець назви
            DataGridViewTextBoxColumn colTrademarkName = new DataGridViewTextBoxColumn();
            colTrademarkName.DataPropertyName = "Name";
            colTrademarkName.Name = "Name";
            dataGridView.Columns.Add(colTrademarkName);

            // Задати вручну стовпець типу
            DataGridViewTextBoxColumn colItemType = new DataGridViewTextBoxColumn();
            colItemType.DataPropertyName = "Type";
            colItemType.Name = "Type";
            dataGridView.Columns.Add(colItemType);

            // Задати вручну стовпець коду картинки
            DataGridViewImageColumn colPicture = new DataGridViewImageColumn();
            colPicture.DataPropertyName = "Picture";
            colPicture.Name = "Picture";
            dataGridView.Columns.Add(colPicture);

            // Задати вручну стовпець коду магазину
            DataGridViewTextBoxColumn colShopAddress = new DataGridViewTextBoxColumn();
            colShopAddress.DataPropertyName = "Shop.ID";
            colShopAddress.Name = "ShopID";
            dataGridView.Columns.Add(colShopAddress);

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                row.Cells[dataGridView.ColumnCount - 4].Value = ((DiscountedItem)row.DataBoundItem).Name;
                row.Cells[dataGridView.ColumnCount - 3].Value = ((DiscountedItem)row.DataBoundItem).Type;
                row.Cells[dataGridView.ColumnCount - 2].Value = ((DiscountedItem)row.DataBoundItem).Picture;
                row.Cells[dataGridView.ColumnCount - 1].Value = ((DiscountedItem)row.DataBoundItem).Shop.ID;
            }

            ((DataGridViewImageColumn)dataGridView.Columns[2]).ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void NewDiscount_Load(object sender, EventArgs e)
        {
            numericUpDownNewPrice.Value = 0;
            numericUpDownOldPrice.Value = 100;

            dateTimePickerStart.Value = DateTime.Now.Date.AddDays(1);
            dateTimePickerEnd.Value = dateTimePickerStart.Value.AddDays(7).AddSeconds(-1);

            LoadItemsByTrademark(trademark);
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
                textBoxDescription.Text != ""
                )
            {
                Name = textBoxName.Text;
                Description = textBoxDescription.Text;
                OldPrice = numericUpDownOldPrice.Value;
                NewPrice = numericUpDownNewPrice.Value;
                Start = dateTimePickerStart.Value;
                End = dateTimePickerEnd.Value;
                Item = (DiscountedItem)selectedRow.DataBoundItem;

                IsFilled = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Не можна створити об'єкт з порожніми полями!", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
