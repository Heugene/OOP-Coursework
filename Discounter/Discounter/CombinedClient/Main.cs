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

        void óâ³éòèToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthForm authForm = new AuthForm();
            authForm.ShowDialog();
            authorizedUser = authForm.person;
            if (!Authorize())
            {
                MessageBox.Show("Ùîñü ï³øëî íå òàê...", "Ïîìèëêà àâòîðèçàö³¿!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        bool Authorize()
        {
            // ïðîïèñàòè ëîã³êó ïðè àâòîðèçàö³¿
            if (authorizedUser as Admin is not null)
            {
                Program.ApplicationMode = AppMode.Admin;
                Text = Text = "Discounter: Admin";
                óâ³éòèToolStripMenuItem.Visible = false;
                âèéòèToolStripMenuItem.Visible = true;
                àäì³í³ñòðóâàííÿToolStripMenuItem.Visible = true;
                ïðîïîçèö³¿ToolStripMenuItem.Visible = false;
                return true;
            }

            else if (authorizedUser as ShopManager is not null)
            {
                Program.ApplicationMode = AppMode.Manager;
                Text = "Discounter: Shop manager";
                óâ³éòèToolStripMenuItem.Visible = false;
                âèéòèToolStripMenuItem.Visible = true;
                àäì³í³ñòðóâàííÿToolStripMenuItem.Visible = false;
                ïðîïîçèö³¿ToolStripMenuItem.Visible = true;
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
            àäì³í³ñòðóâàííÿToolStripMenuItem.Visible = false;
            ïðîïîçèö³¿ToolStripMenuItem.Visible = false;
        }

        private void âèéòèToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deauthorize();
        }

        private void PopulateItemsTEST()
        {
            DiscountListItem[] list= new DiscountListItem[20];
            Trademark TEST_trademark = new Trademark(1, "Òåñò ÒÌ", "Òåñòîâà òîðãîâà ìàðêà.");
            Shop TEST_shop = new Shop(1, TEST_trademark, "Òåñòîâà àäðåñà");
            DiscountedItem TEST_item = new DiscountedItem(1, "Òåñòîâà êîâáàñà", ItemType.Product, "Êîâáàñíèé âèð³á òåñòâîãî ´àòóíêó", TEST_shop);
            if (flowLayoutPanel1.Controls.Count > 0)
            {
                flowLayoutPanel1.Controls.Clear();
            }
            for (int i = 0; i < list.Length; i++)
            {
                list[i] = new DiscountListItem();
                list[i].Discount = new Discount(i + 1, "ÍÅÉÌÎÂ²ÐÍ² ÒÅÑÒÈ", TEST_item, "Ñïåö³àëüíà àêö³ÿ ò³ëüêè íà ïåð³îä òåñòó ³íòåðôåéñó", 25.99m, 15.99m, DateTime.Now, DateTime.Now.AddDays(7));
                flowLayoutPanel1.Controls.Add(list[i]);
            }
        }
    }
}
