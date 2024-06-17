using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CombinedClient
{
    public partial class EditShopManager : Form
    {
        public bool IsFilled { get; private set; } = false;
        public string Name { get; private set; }
        public string Phone { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }


        public EditShopManager(ShopManager manager)
        {
            InitializeComponent();
            Name = manager.Name;
            Phone = manager.PhoneNumber;
            Email = manager.Email;
            Password = manager.Password;
            textBoxName.Text = Name;
            maskedTextBoxPhone.Text = Phone;
            textBoxEmail.Text = Email;
            textBoxPassword.Text = Password;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != "" &&
                maskedTextBoxPhone.Text != "" &&
                textBoxEmail.Text != "" &&
                textBoxPassword.Text != ""
                )
            {
                Name = textBoxName.Text;
                Phone = maskedTextBoxPhone.Text;
                Email = textBoxEmail.Text;
                Password = textBoxPassword.Text;
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
