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
    public partial class DiscountReview : Form
    {
        Discount discount;
        string currency = " грн";

        public DiscountReview(Discount discount)
        {
            this.discount = discount;
            InitializeComponent();
        }

        private void DiscountReview_Load(object sender, EventArgs e)
        {
            labelItemName.Text = discount.Item.Name;
            labelItemType.Text = "Тип: " + discount.Item.Type;
            pictureBox.Image = discount.Item.Picture;
            textBoxItemDescription.Text = discount.Item.Description;
            labelOldPrice.Text = "Стара ціна: " + discount.OldPrice.ToString("0.00") + currency;
            labelNewPrice.Text = "Нова ціна: " + discount.NewPrice.ToString("0.00") + currency + $" (-{discount.Percentage}%)";

            labelDiscountName.Text = "Акція: " + discount.Name;
            textBoxDiscountDescription.Text = discount.Description;
            labelStart_End.Text = $"Термін дії: {discount.StartDateTime} - {discount.EndDateTime}";

            labelTrademark.Text = "Торгова марка: " + discount.Item.Shop.Trademark.Name;
            labelShopAddress.Text += $"\n{discount.Item.Shop.Address}\n(Можливо, цей предмет є і в інших магазинах даної ТМ)";
        }
    }
}
