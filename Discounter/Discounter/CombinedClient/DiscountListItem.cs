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

        public Discount Discount
        {
            get { return  discount; }
            set 
            {
                discount = value;
                labelDiscName.Text = discount.Name;
                labelItemName.Text = discount.Item.Name;
                labelOldPrice.Text = discount.OldPrice.ToString();
                labelNewPrice.Text = discount.NewPrice.ToString();
                labelStart_End.Text = $"{discount.StartDateTime} - {discount.EndDateTime}";
                pictureBox.Image = discount.Item.Picture;
            }
        }
        

        public DiscountListItem()
        {
            InitializeComponent();
        }
    }
}
