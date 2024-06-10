﻿using System;
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
    public partial class ManagerCRUD : Form
    {
        List<ShopManager> managers;

        DataGridViewRow selectedRow;

        public ManagerCRUD()
        {
            InitializeComponent();
        }

        private void Refresh()
        {

            // Обнулити датасурс у датагріду
            dataGridView.DataSource = null;
            dataGridView.Columns.Clear();

            // Заповнити колекцію об'єктів, використавши контролер
            managers = DAL.ManagerController.GetAllShopManagers();

            // Заповнити датагрід з колекції
            dataGridView.DataSource = managers;

            // Замінити вкладені об'єкти назвами
            dataGridView.Columns[0].Visible = false;
            DataGridViewTextBoxColumn colTrademarkName = new DataGridViewTextBoxColumn();
            colTrademarkName.DataPropertyName = "ManagedShop.Trademark.Name";
            colTrademarkName.Name = "ManagedShopTrademark";
            dataGridView.Columns.Add(colTrademarkName);

            DataGridViewTextBoxColumn colShopID = new DataGridViewTextBoxColumn();
            colShopID.DataPropertyName = "ManagedShop.ID";
            colShopID.Name = "ManagedShopID";
            dataGridView.Columns.Add(colShopID);

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                row.Cells[dataGridView.ColumnCount - 2].Value = ((ShopManager)row.DataBoundItem).ManagedShop.Trademark.Name;
                row.Cells[dataGridView.ColumnCount - 1].Value = ((ShopManager)row.DataBoundItem).ManagedShop.ID;
            }
        }

        private void ManagerCRUD_Load(object sender, EventArgs e)
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

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            // Переконатися, що користувач дійсно хоче цього
            if (MessageBox.Show("Ви дійсно хочете видалити обраний запис?", "Підтвердіть операцію", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Звернутися до контролера і видалити запис
                if (DAL.ManagerController.DeleteShopManager((ShopManager)selectedRow.DataBoundItem))
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
