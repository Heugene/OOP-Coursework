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
            PopulateItemsTEST();
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

        private void PopulateItemsTEST()
        {
            DiscountListItem[] list= new DiscountListItem[20];
            Trademark TEST_trademark = new Trademark(1, "���� ��", "������� ������� �����.");
            Shop TEST_shop = new Shop(1, TEST_trademark, "������� ������");
            DiscountedItem TEST_item = new DiscountedItem(1, "������� �������", ItemType.Product, "��������� ���� �������� �������", TEST_shop);
            if (flowLayoutPanel1.Controls.Count > 0)
            {
                flowLayoutPanel1.Controls.Clear();
            }
            for (int i = 0; i < list.Length; i++)
            {
                list[i] = new DiscountListItem();
                list[i].Discount = new Discount(i + 1, "�����²�Ͳ �����", TEST_item, "���������� ����� ����� �� ����� ����� ����������", 25.99m, 15.99m, DateTime.Now, DateTime.Now.AddDays(7));
                flowLayoutPanel1.Controls.Add(list[i]);
            }
        }
    }
}
