using Domain;

namespace CombinedClient
{
    public partial class Main : Form
    {
        static string searchBarPlaceholder = "�����...";
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

        void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthForm authForm = new AuthForm();
            authForm.ShowDialog();
            authorizedUser = authForm.person;
            if (!Authorize())
            {
                MessageBox.Show("���� ���� �� ���...", "������� �����������!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        bool Authorize()
        {
            // ��������� ����� ��� �����������
            if (authorizedUser as Admin is not null)
            {
                Program.ApplicationMode = AppMode.Admin;
                Text = Text = "Discounter: Admin";
                �����ToolStripMenuItem.Visible = false;
                �����ToolStripMenuItem.Visible = true;
                �������������ToolStripMenuItem.Visible = true;
                ����������ToolStripMenuItem.Visible = false;
                return true;
            }

            else if (authorizedUser as ShopManager is not null)
            {
                Program.ApplicationMode = AppMode.Manager;
                Text = "Discounter: Shop manager";
                �����ToolStripMenuItem.Visible = false;
                �����ToolStripMenuItem.Visible = true;
                �������������ToolStripMenuItem.Visible = false;
                ����������ToolStripMenuItem.Visible = true;
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
            �����ToolStripMenuItem.Visible = true;
            �����ToolStripMenuItem.Visible = false;
            �������������ToolStripMenuItem.Visible = false;
            ����������ToolStripMenuItem.Visible = false;
        }

        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deauthorize();
        }
    }
}
