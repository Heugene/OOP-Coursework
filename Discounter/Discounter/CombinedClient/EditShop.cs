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
    public partial class EditShop : Form
    {
        public bool IsFilled { get; private set; } = false;
        public string Address { get; private set; }

        public EditShop(Shop shop)
        {
            InitializeComponent();
            Address = shop.Address;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (textBoxAddress.Text != "")
            {
                Address = textBoxAddress.Text;
                IsFilled = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Не можна задати об'єкт з порожніми полями!", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
