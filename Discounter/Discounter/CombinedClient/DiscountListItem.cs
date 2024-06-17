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
    public partial class DiscountListItem : UserControl
    {
        Discount discount;
        string currency = " грн";

        public Discount Discount
        {
            get { return discount; }
            set
            {
                discount = value;
                labelDiscName.Text = "Акція: " + discount.Name;
                labelItemName.Text = discount.Item.Name;
                labelOldPrice.Text = "Стара ціна: " + discount.OldPrice.ToString("0.00") + currency;
                labelNewPrice.Text = "Нова ціна: " + discount.NewPrice.ToString("0.00") + currency + $" (-{discount.Percentage}%)";
                labelStart_End.Text = $"{discount.StartDateTime} - {discount.EndDateTime}";
                labelTrademark.Text = "ТМ: " + discount.Item.Shop.Trademark.Name;
                pictureBox.Image = discount.Item.Picture;
            }
        }


        public DiscountListItem()
        {
            InitializeComponent();
        }

        private void DiscountListItem_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Linen;
        }

        private void DiscountListItem_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Bisque;
        }

        private void DiscountListItem_Click(object sender, EventArgs e)
        {
            // Відкрити форму для перегляду повної інформації про знижку
            DiscountReview form = new DiscountReview(discount);
            form.ShowDialog();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            // Відкрити форму для перегляду повної інформації про знижку
            DiscountReview form = new DiscountReview(discount);
            form.ShowDialog();
        }

        private void pictureBox_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Linen;
        }

        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Bisque;
        }
    }
}
