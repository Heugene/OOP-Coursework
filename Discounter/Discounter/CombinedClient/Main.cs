using Domain;

namespace CombinedClient
{
    public partial class Main : Form
    {
        static string searchBarPlaceholder = "Ïîøóê...";
        static Person? authorizedUser = null;


        public Main()
        {
            InitializeComponent();
        }

        void Main_Load(object sender, EventArgs e)
        {
            toolStripTextBoxSearch.Text = searchBarPlaceholder;
            Deauthorize();
        }

        void toolStripTextBoxSearch_Enter(object sender, EventArgs e)
        {
            if (toolStripTextBoxSearch.Text == searchBarPlaceholder)
            {
                toolStripTextBoxSearch.Text = "";
            }
        }

        void toolStripTextBoxSearch_Leave(object sender, EventArgs e)
        {
            if (toolStripTextBoxSearch.Text == "")
            {
                toolStripTextBoxSearch.Text = searchBarPlaceholder;
            }
        }

        void óâ³éòèToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthForm authForm = new AuthForm();
            authForm.ShowDialog();
            authorizedUser = authForm.person;
            if (!Authorize())
            {
                MessageBox.Show("Ùîñü ï³øëî íå òàê...", "Ïîìèëêà àâòîğèçàö³¿!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        bool Authorize()
        {
            // ïğîïèñàòè ëîã³êó ïğè àâòîğèçàö³¿
            if (authorizedUser as Admin is not null)
            {
                Program.ApplicationMode = AppMode.Admin;
                Text = Text = "Discounter: Admin";
                óâ³éòèToolStripMenuItem.Visible = false;
                âèéòèToolStripMenuItem.Visible = true;
                àäì³í³ñòğóâàííÿToolStripMenuItem.Visible = true;
                ïğîïîçèö³¿ToolStripMenuItem.Visible = false;
                return true;
            }

            else if (authorizedUser as ShopManager is not null)
            {
                Program.ApplicationMode = AppMode.Manager;
                Text = "Discounter: Shop manager";
                óâ³éòèToolStripMenuItem.Visible = false;
                âèéòèToolStripMenuItem.Visible = true;
                àäì³í³ñòğóâàííÿToolStripMenuItem.Visible = false;
                ïğîïîçèö³¿ToolStripMenuItem.Visible = true;
                return true;
            }
            else
            {
                return false;
            }
        }

        void Deauthorize()
        {
            Program.ApplicationMode = AppMode.Unauthorized;
            Text = "Discounter: Unauthorized";
            óâ³éòèToolStripMenuItem.Visible = true;
            âèéòèToolStripMenuItem.Visible = false;
            àäì³í³ñòğóâàííÿToolStripMenuItem.Visible = false;
            ïğîïîçèö³¿ToolStripMenuItem.Visible = false;
        }

        private void âèéòèToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deauthorize();
        }
    }
}
