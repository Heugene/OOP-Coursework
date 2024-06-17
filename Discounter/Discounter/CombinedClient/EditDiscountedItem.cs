﻿using Domain;
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
    public partial class EditDiscountedItem : Form
    {
        public bool IsFilled { get; private set; } = false;
        public string Name { get; private set; }
        public string Description { get; private set; }
        public Bitmap Picture { get; private set; }

        public EditDiscountedItem(DiscountedItem item)
        {
            InitializeComponent();
            Name = item.Name;
            Description = item.Description;
            Picture = item.Picture;
            textBoxName.Text = item.Name;
            textBoxDescription.Text = item.Description;
            pictureBox.Image = item.Picture;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != "" &&
                textBoxDescription.Text != "" &&
                pictureBox.Image is not null
                )
            {
                Name = textBoxName.Text;
                Description = textBoxDescription.Text;
                Picture = (Bitmap)pictureBox.Image;
                IsFilled = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Не можна задати об'єкт з порожніми полями!", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonSetPicture_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog dlg = new OpenFileDialog())
                {
                    dlg.Title = "Open Image";
                    dlg.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG"; ;

                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        pictureBox.Image = new Bitmap(dlg.FileName);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Помилка завантаження зображення! Спробуйте інше.", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
