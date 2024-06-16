namespace CombinedClient
{
    partial class NewDiscountedItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewDiscountedItem));
            textBoxName = new TextBox();
            label1 = new Label();
            buttonCreate = new Button();
            groupBox1 = new GroupBox();
            radioButtonService = new RadioButton();
            radioButtonProduct = new RadioButton();
            textBoxDescription = new TextBox();
            label2 = new Label();
            pictureBox = new PictureBox();
            buttonSetPicture = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(12, 41);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(568, 31);
            textBoxName.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(61, 25);
            label1.TabIndex = 5;
            label1.Text = "Назва";
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(248, 495);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(112, 34);
            buttonCreate.TabIndex = 22;
            buttonCreate.Text = "Створити";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButtonService);
            groupBox1.Controls.Add(radioButtonProduct);
            groupBox1.Location = new Point(419, 367);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(136, 107);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Тип";
            // 
            // radioButtonService
            // 
            radioButtonService.AutoSize = true;
            radioButtonService.Location = new Point(16, 65);
            radioButtonService.Name = "radioButtonService";
            radioButtonService.Size = new Size(103, 29);
            radioButtonService.TabIndex = 1;
            radioButtonService.TabStop = true;
            radioButtonService.Text = "Послуга";
            radioButtonService.UseVisualStyleBackColor = true;
            // 
            // radioButtonProduct
            // 
            radioButtonProduct.AutoSize = true;
            radioButtonProduct.Location = new Point(16, 30);
            radioButtonProduct.Name = "radioButtonProduct";
            radioButtonProduct.Size = new Size(87, 29);
            radioButtonProduct.TabIndex = 0;
            radioButtonProduct.TabStop = true;
            radioButtonProduct.Text = "Товар";
            radioButtonProduct.UseVisualStyleBackColor = true;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(12, 120);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.ScrollBars = ScrollBars.Vertical;
            textBoxDescription.Size = new Size(348, 354);
            textBoxDescription.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 85);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 25;
            label2.Text = "Опис";
            // 
            // pictureBox
            // 
            pictureBox.Image = (Image)resources.GetObject("pictureBox.Image");
            pictureBox.Location = new Point(388, 109);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(192, 192);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 26;
            pictureBox.TabStop = false;
            // 
            // buttonSetPicture
            // 
            buttonSetPicture.Location = new Point(388, 307);
            buttonSetPicture.Name = "buttonSetPicture";
            buttonSetPicture.Size = new Size(192, 34);
            buttonSetPicture.TabIndex = 27;
            buttonSetPicture.Text = "Задати картинку";
            buttonSetPicture.UseVisualStyleBackColor = true;
            buttonSetPicture.Click += buttonSetPicture_Click;
            // 
            // NewDiscountedItem
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 544);
            Controls.Add(buttonSetPicture);
            Controls.Add(pictureBox);
            Controls.Add(label2);
            Controls.Add(textBoxDescription);
            Controls.Add(groupBox1);
            Controls.Add(buttonCreate);
            Controls.Add(textBoxName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimumSize = new Size(625, 600);
            Name = "NewDiscountedItem";
            StartPosition = FormStartPosition.CenterParent;
            Text = "NewDiscountedItem";
            Load += NewDiscountedItem_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private Label label1;
        private Button buttonCreate;
        private GroupBox groupBox1;
        private RadioButton radioButtonService;
        private RadioButton radioButtonProduct;
        private TextBox textBoxDescription;
        private Label label2;
        private PictureBox pictureBox;
        private Button buttonSetPicture;
    }
}