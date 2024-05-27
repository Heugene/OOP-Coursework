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
        Person person;

        public AuthForm(Person person)
        {
            this.person = person;
            InitializeComponent();
        }

        bool Identificate(string login)
        {
            // перевірка, чи є такий логін в БД через контролер
            throw new NotImplementedException();
        }

        bool Authentificate(string login, string password)
        {
            // перевірка, чи співпадає у даного логіну пароль із зазначеним
            throw new NotImplementedException();
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
