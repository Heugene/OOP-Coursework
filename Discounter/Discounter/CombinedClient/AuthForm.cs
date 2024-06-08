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
    public partial class AuthForm : Form
    {
        internal Person? person;

        public AuthForm()
        {
            InitializeComponent();
        }

        bool Identificate(string login)
        {
            // перевірка, чи є такий логін в БД через контролер
            if (radioButton1.Checked)
            {
                if (DAL.AdminController.Identificate(login))
                {
                    return true;
                }
                else return false;
            }
            if (radioButton2.Checked) 
            {
                if (DAL.ManagerController.Identificate(login))
                {
                    return true;
                }
                else return false;
            }
            return false;
        }

        bool Authentificate(string login, string password)
        {
            // перевірка, чи співпадає у даного логіну пароль із зазначеним
            if (radioButton1.Checked)
            {
                if (DAL.AdminController.Authentificate(login, password))
                {
                    return true;
                }
                else return false;
            }
            if (radioButton2.Checked)
            {
                if (DAL.ManagerController.Authentificate(login, password))
                {
                    return true;
                }
                else return false;
            }
            return false;
        }


        private void ButtonAuthorize_Click(object sender, EventArgs e)
        {
            if (Identificate(textBoxLogin.Text))
            {
                if (Authentificate(textBoxLogin.Text, maskedTextBox1.Text))
                {
                    MessageBox.Show("Авторизація успішна!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Звернутися до контролера, щоб задав змінну юзера.
                    // person = ...
                    if (radioButton1.Checked)
                    {
                        person = DAL.AdminController.GetAdmin(textBoxLogin.Text, maskedTextBox1.Text);
                    }
                    if (radioButton2.Checked)
                    {
                        person = DAL.ManagerController.GetShopManager(textBoxLogin.Text, maskedTextBox1.Text);
                    }
                    Close();
                }
                else
                {
                    MessageBox.Show("Невірний пароль", "Помилка аутентифікації!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Невірний логін", "Помилка ідентифікації!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                maskedTextBox1.UseSystemPasswordChar = false;
            }
            else
            {
                maskedTextBox1.UseSystemPasswordChar = true;
            }
        }
    }
}
