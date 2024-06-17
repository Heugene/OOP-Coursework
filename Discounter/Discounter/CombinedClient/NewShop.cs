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
    public partial class NewShop : Form
    {
        public bool IsFilled { get; private set; } = false;
        public string Address { get; private set; }
        public Trademark trademark { get; private set; }

        DataGridViewRow selectedRow;

        public NewShop()
        {
            InitializeComponent();
        }

        private void NewShop_Load(object sender, EventArgs e)
        {
            // Заповнити датагрід назвами торгових марок

            // Вимкнути автогенерацію колонок
            dataGridView.AutoGenerateColumns = false;

            // Дістати список торгових марок з БД
            List<Trademark> trademarks = DAL.TrademarkController.GetTrademarks();
            
            // Заповнити датагрід вмістом колекції
            dataGridView.DataSource = trademarks;

            // Задати вручну стовпець назви
            DataGridViewTextBoxColumn colTrademarkName = new DataGridViewTextBoxColumn();
            colTrademarkName.DataPropertyName = "Name";
            colTrademarkName.Name = "TrademarkName";
            dataGridView.Columns.Add(colTrademarkName);

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                row.Cells[dataGridView.ColumnCount - 1].Value = ((Trademark)row.DataBoundItem).Name;
            }
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
            if (textBoxAddress.Text != "" && selectedRow is not null)
            {
                Address = textBoxAddress.Text;
                trademark = (Trademark)selectedRow.DataBoundItem;
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
