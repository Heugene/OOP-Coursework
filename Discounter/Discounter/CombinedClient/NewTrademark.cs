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
    public partial class NewTrademark : Form
    {
        public bool IsFilled { get; private set; } = false;
        public string Name { get; private set; }
        public string Description { get; private set; }

        public NewTrademark()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != "" && textBoxDescription.Text != "")
            {
                Name = textBoxName.Text;
                Description = textBoxDescription.Text;
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
