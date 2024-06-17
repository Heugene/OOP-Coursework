namespace CombinedClient
{
    partial class DiscountListItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox = new PictureBox();
            labelDiscName = new Label();
            labelItemName = new Label();
            labelStart_End = new Label();
            labelOldPrice = new Label();
            labelNewPrice = new Label();
            labelTrademark = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(3, 3);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(150, 150);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            pictureBox.Click += pictureBox_Click;
            pictureBox.MouseEnter += pictureBox_MouseEnter;
            pictureBox.MouseLeave += pictureBox_MouseLeave;
            // 
            // labelDiscName
            // 
            labelDiscName.AutoSize = true;
            labelDiscName.Font = new Font("Segoe UI", 12F);
            labelDiscName.Location = new Point(159, 3);
            labelDiscName.Name = "labelDiscName";
            labelDiscName.Size = new Size(172, 32);
            labelDiscName.TabIndex = 1;
            labelDiscName.Text = "DiscountName";
            // 
            // labelItemName
            // 
            labelItemName.AutoSize = true;
            labelItemName.Font = new Font("Segoe UI", 12F);
            labelItemName.Location = new Point(159, 35);
            labelItemName.Name = "labelItemName";
            labelItemName.Size = new Size(126, 32);
            labelItemName.TabIndex = 2;
            labelItemName.Text = "ItemName";
            // 
            // labelStart_End
            // 
            labelStart_End.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelStart_End.AutoSize = true;
            labelStart_End.Font = new Font("Segoe UI", 12F);
            labelStart_End.Location = new Point(749, 110);
            labelStart_End.Name = "labelStart_End";
            labelStart_End.Size = new Size(237, 32);
            labelStart_End.TabIndex = 3;
            labelStart_End.Text = "Start time - end time";
            // 
            // labelOldPrice
            // 
            labelOldPrice.AutoSize = true;
            labelOldPrice.Font = new Font("Segoe UI", 12F);
            labelOldPrice.Location = new Point(159, 76);
            labelOldPrice.Name = "labelOldPrice";
            labelOldPrice.Size = new Size(123, 32);
            labelOldPrice.TabIndex = 4;
            labelOldPrice.Text = "Old price: ";
            // 
            // labelNewPrice
            // 
            labelNewPrice.AutoSize = true;
            labelNewPrice.Font = new Font("Segoe UI", 12F);
            labelNewPrice.ForeColor = Color.DarkRed;
            labelNewPrice.Location = new Point(159, 108);
            labelNewPrice.Name = "labelNewPrice";
            labelNewPrice.Size = new Size(133, 32);
            labelNewPrice.TabIndex = 5;
            labelNewPrice.Text = "New price: ";
            // 
            // labelTrademark
            // 
            labelTrademark.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelTrademark.AutoSize = true;
            labelTrademark.Font = new Font("Segoe UI", 12F);
            labelTrademark.Location = new Point(794, 3);
            labelTrademark.Name = "labelTrademark";
            labelTrademark.Size = new Size(192, 32);
            labelTrademark.TabIndex = 6;
            labelTrademark.Text = "Trademark name";
            labelTrademark.TextAlign = ContentAlignment.MiddleRight;
            // 
            // DiscountListItem
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            Controls.Add(labelTrademark);
            Controls.Add(labelNewPrice);
            Controls.Add(labelOldPrice);
            Controls.Add(labelStart_End);
            Controls.Add(labelItemName);
            Controls.Add(labelDiscName);
            Controls.Add(pictureBox);
            Name = "DiscountListItem";
            Size = new Size(1000, 160);
            Click += DiscountListItem_Click;
            MouseEnter += DiscountListItem_MouseEnter;
            MouseLeave += DiscountListItem_MouseLeave;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox;
        private Label labelDiscName;
        private Label labelItemName;
        private Label labelStart_End;
        private Label labelOldPrice;
        private Label labelNewPrice;
        private Label labelTrademark;
    }
}
