using Domain;
using System.Text;
using System.Text.Json;

namespace CombinedClient
{
    public partial class Main : Form
    {
        static string searchBarPlaceholder = "�����...";
        static Person? authorizedUser = null;

        static string jsonPath = Application.StartupPath + @"\discounts.json";

        public Main()
        {
            InitializeComponent();
        }

        void Main_Load(object sender, EventArgs e)
        {
            toolStripTextBoxSearch.Text = searchBarPlaceholder;
            Deauthorize();
            //PopulateItemsTEST();
            LoadDiscounts();
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
            DiscountListItem[] list = new DiscountListItem[20];
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
                list[i].Discount = new Discount(i + 1, "�����²�Ͳ �����", TEST_item, "���������� ����� ����� �� ����� ����� ����������", 25.99m, 15.99m, DateTime.Now, DateTime.Now.AddDays(7), true, false);
                flowLayoutPanel1.Controls.Add(list[i]);
            }
        }

        private void LoadDiscounts()
        {
            try
            {
                //throw new Exception("Deserialization Test");

                List<Discount> discounts = DAL.DiscountController.GetAllActualDiscounts();
                DiscountListItem[] itemList = new DiscountListItem[discounts.Count];

                if (flowLayoutPanel1.Controls.Count > 0)
                {
                    flowLayoutPanel1.Controls.Clear();
                }

                for (int i = 0; i < itemList.Length; i++)
                {
                    itemList[i] = new DiscountListItem();
                    itemList[i].Discount = discounts[i];
                    flowLayoutPanel1.Controls.Add(itemList[i]);
                }


                SerializeDiscounts(discounts, jsonPath);
            }
            catch
            {
                MessageBox.Show("���� ���� �� ���... ������ ���������� �������� ������.", "������� ������������ ������!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadDiscountsFromFile();
            }
        }

        private void SerializeDiscounts(List<Discount> discounts, string path)
        {
            try
            {
                StringBuilder jsonstring = new StringBuilder();

                foreach (var item in discounts)
                {
                    jsonstring.AppendLine(JsonSerializer.Serialize<Discount>(item));
                }

                File.WriteAllText(path, jsonstring.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"���� ���� �� ��� ��� �������� ������. \n�������: {ex.Message}", "������� ���������� ������!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<Discount> DeserializeDiscounts(string path)
        {
            List<Discount> discounts = new List<Discount>();
            try
            {
                List<string> lines = new List<string>();
                lines = File.ReadAllLines(path).ToList();

                foreach (var item in lines)
                {
                    Discount? discount = JsonSerializer.Deserialize<Discount>(item);
                    if (discount is not null)
                    {
                        discounts.Add(discount);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"���� ���� �� ��� ��� ����������� ���������� ������. \n�������: {ex.Message}", "������� ���������� ���������� ������!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return discounts;
        }

        private void LoadDiscountsFromFile()
        {
            List<Discount> discounts = DeserializeDiscounts(jsonPath);
            DiscountListItem[] itemList = new DiscountListItem[discounts.Count];

            if (flowLayoutPanel1.Controls.Count > 0)
            {
                flowLayoutPanel1.Controls.Clear();
            }

            for (int i = 0; i < itemList.Length; i++)
            {
                itemList[i] = new DiscountListItem();
                itemList[i].Discount = discounts[i];
                flowLayoutPanel1.Controls.Add(itemList[i]);
            }
        }

        private void �����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrademarkCRUD form = new TrademarkCRUD();
            form.ShowDialog();
        }

        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShopCRUD form = new ShopCRUD();
            form.ShowDialog();
        }

        private void �����������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerCRUD form = new ManagerCRUD();
            form.ShowDialog();
        }

        private void ��������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DiscountRequestReview form = new DiscountRequestReview();
            form.ShowDialog();
        }

        private void ������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DiscountedItemCRUD form = new DiscountedItemCRUD(authorizedUser as ShopManager);
            form.ShowDialog();
        }

        private void ������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DiscountCRUD form = new DiscountCRUD(authorizedUser as ShopManager);
            form.ShowDialog();
        }
    }
}
