namespace CombinedClient
{
    partial class DiscountReview
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiscountReview));
            pictureBox = new PictureBox();
            textBoxItemDescription = new TextBox();
            groupBox1 = new GroupBox();
            labelNewPrice = new Label();
            labelOldPrice = new Label();
            labelItemType = new Label();
            labelItemName = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            labelShopAddress = new Label();
            labelTrademark = new Label();
            labelStart_End = new Label();
            label5 = new Label();
            textBoxDiscountDescription = new TextBox();
            labelDiscountName = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.Image = (Image)resources.GetObject("pictureBox.Image");
            pictureBox.Location = new Point(9, 146);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(192, 192);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 27;
            pictureBox.TabStop = false;
            // 
            // textBoxItemDescription
            // 
            textBoxItemDescription.Location = new Point(219, 173);
            textBoxItemDescription.Multiline = true;
            textBoxItemDescription.Name = "textBoxItemDescription";
            textBoxItemDescription.ReadOnly = true;
            textBoxItemDescription.ScrollBars = ScrollBars.Vertical;
            textBoxItemDescription.Size = new Size(525, 165);
            textBoxItemDescription.TabIndex = 28;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelNewPrice);
            groupBox1.Controls.Add(labelOldPrice);
            groupBox1.Controls.Add(labelItemType);
            groupBox1.Controls.Add(labelItemName);
            groupBox1.Controls.Add(textBoxItemDescription);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(pictureBox);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBox1.Location = new Point(22, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(755, 423);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Text = "Інформація про предмет пропозиції";
            // 
            // labelNewPrice
            // 
            labelNewPrice.AutoSize = true;
            labelNewPrice.Font = new Font("Segoe UI", 12F);
            labelNewPrice.ForeColor = Color.DarkRed;
            labelNewPrice.Location = new Point(12, 376);
            labelNewPrice.Name = "labelNewPrice";
            labelNewPrice.Size = new Size(133, 32);
            labelNewPrice.TabIndex = 34;
            labelNewPrice.Text = "New price: ";
            // 
            // labelOldPrice
            // 
            labelOldPrice.AutoSize = true;
            labelOldPrice.Font = new Font("Segoe UI", 12F);
            labelOldPrice.Location = new Point(12, 344);
            labelOldPrice.Name = "labelOldPrice";
            labelOldPrice.Size = new Size(123, 32);
            labelOldPrice.TabIndex = 33;
            labelOldPrice.Text = "Old price: ";
            // 
            // labelItemType
            // 
            labelItemType.AutoSize = true;
            labelItemType.Font = new Font("Segoe UI", 12F);
            labelItemType.Location = new Point(9, 90);
            labelItemType.Name = "labelItemType";
            labelItemType.Size = new Size(168, 32);
            labelItemType.TabIndex = 32;
            labelItemType.Text = "Тип предмету";
            // 
            // labelItemName
            // 
            labelItemName.AutoSize = true;
            labelItemName.Font = new Font("Segoe UI", 12F);
            labelItemName.Location = new Point(6, 47);
            labelItemName.Name = "labelItemName";
            labelItemName.Size = new Size(192, 32);
            labelItemName.TabIndex = 31;
            labelItemName.Text = "Назва предмету";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(219, 138);
            label2.Name = "label2";
            label2.Size = new Size(312, 32);
            label2.TabIndex = 29;
            label2.Text = "Опис предмету пропозиції";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(labelShopAddress);
            groupBox2.Controls.Add(labelTrademark);
            groupBox2.Controls.Add(labelStart_End);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(textBoxDiscountDescription);
            groupBox2.Controls.Add(labelDiscountName);
            groupBox2.Font = new Font("Segoe UI", 12F);
            groupBox2.Location = new Point(22, 463);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(755, 487);
            groupBox2.TabIndex = 31;
            groupBox2.TabStop = false;
            groupBox2.Text = "Інформація про акційну пропозицію";
            // 
            // labelShopAddress
            // 
            labelShopAddress.AutoSize = true;
            labelShopAddress.Location = new Point(12, 381);
            labelShopAddress.Name = "labelShopAddress";
            labelShopAddress.Size = new Size(448, 32);
            labelShopAddress.TabIndex = 37;
            labelShopAddress.Text = "Адреса магазину, що створив предмет:";
            // 
            // labelTrademark
            // 
            labelTrademark.AutoSize = true;
            labelTrademark.Location = new Point(12, 340);
            labelTrademark.Name = "labelTrademark";
            labelTrademark.Size = new Size(182, 32);
            labelTrademark.TabIndex = 36;
            labelTrademark.Text = "Торгова марка:";
            // 
            // labelStart_End
            // 
            labelStart_End.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelStart_End.AutoSize = true;
            labelStart_End.Font = new Font("Segoe UI", 12F);
            labelStart_End.Location = new Point(12, 308);
            labelStart_End.Name = "labelStart_End";
            labelStart_End.Size = new Size(237, 32);
            labelStart_End.TabIndex = 35;
            labelStart_End.Text = "Start time - end time";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 93);
            label5.Name = "label5";
            label5.Size = new Size(128, 32);
            label5.TabIndex = 34;
            label5.Text = "Опис акції";
            // 
            // textBoxDiscountDescription
            // 
            textBoxDiscountDescription.Location = new Point(9, 128);
            textBoxDiscountDescription.Multiline = true;
            textBoxDiscountDescription.Name = "textBoxDiscountDescription";
            textBoxDiscountDescription.ReadOnly = true;
            textBoxDiscountDescription.ScrollBars = ScrollBars.Vertical;
            textBoxDiscountDescription.Size = new Size(735, 165);
            textBoxDiscountDescription.TabIndex = 33;
            // 
            // labelDiscountName
            // 
            labelDiscountName.AutoSize = true;
            labelDiscountName.Font = new Font("Segoe UI", 12F);
            labelDiscountName.Location = new Point(9, 49);
            labelDiscountName.Name = "labelDiscountName";
            labelDiscountName.Size = new Size(136, 32);
            labelDiscountName.TabIndex = 32;
            labelDiscountName.Text = "Назва акції";
            // 
            // DiscountReview
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 962);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimumSize = new Size(820, 1018);
            Name = "DiscountReview";
            StartPosition = FormStartPosition.CenterParent;
            Text = "DiscountReview";
            Load += DiscountReview_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox;
        private TextBox textBoxItemDescription;
        private GroupBox groupBox1;
        private Label labelItemType;
        private Label labelItemName;
        private GroupBox groupBox2;
        private Label label2;
        private Label label5;
        private TextBox textBoxDiscountDescription;
        private Label labelDiscountName;
        private Label labelNewPrice;
        private Label labelOldPrice;
        private Label labelTrademark;
        private Label labelStart_End;
        private Label labelShopAddress;
    }
}