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
    public partial class EditTrademark : Form
    {
        public bool IsFilled { get; private set; } = false;
        public string Name { get; private set; }
        public string Description { get; private set; }

        public EditTrademark(Trademark trademark)
        {
            InitializeComponent();
            textBoxName.Text = trademark.Name;
            textBoxDescription.Text = trademark.Description;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
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
                MessageBox.Show("Не можна задати об'єкт з порожніми полями!", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
