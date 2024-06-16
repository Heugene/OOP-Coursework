namespace CombinedClient
{
    partial class EditDiscountedItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditDiscountedItem));
            buttonSetPicture = new Button();
            pictureBox = new PictureBox();
            label2 = new Label();
            textBoxDescription = new TextBox();
            buttonConfirm = new Button();
            textBoxName = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // buttonSetPicture
            // 
            buttonSetPicture.Location = new Point(596, 238);
            buttonSetPicture.Name = "buttonSetPicture";
            buttonSetPicture.Size = new Size(192, 34);
            buttonSetPicture.TabIndex = 34;
            buttonSetPicture.Text = "Задати картинку";
            buttonSetPicture.UseVisualStyleBackColor = true;
            buttonSetPicture.Click += buttonSetPicture_Click;
            // 
            // pictureBox
            // 
            pictureBox.Image = (Image)resources.GetObject("pictureBox.Image");
            pictureBox.Location = new Point(596, 40);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(192, 192);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 33;
            pictureBox.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 84);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 32;
            label2.Text = "Опис";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(12, 119);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.ScrollBars = ScrollBars.Vertical;
            textBoxDescription.Size = new Size(568, 153);
            textBoxDescription.TabIndex = 31;
            // 
            // buttonConfirm
            // 
            buttonConfirm.Location = new Point(340, 295);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(112, 34);
            buttonConfirm.TabIndex = 30;
            buttonConfirm.Text = "Зберегти";
            buttonConfirm.UseVisualStyleBackColor = true;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(12, 40);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(568, 31);
            textBoxName.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(61, 25);
            label1.TabIndex = 28;
            label1.Text = "Назва";
            // 
            // EditDiscountedItem
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 344);
            Controls.Add(buttonSetPicture);
            Controls.Add(pictureBox);
            Controls.Add(label2);
            Controls.Add(textBoxDescription);
            Controls.Add(buttonConfirm);
            Controls.Add(textBoxName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimumSize = new Size(822, 400);
            Name = "EditDiscountedItem";
            StartPosition = FormStartPosition.CenterParent;
            Text = "EditDiscountedItem";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSetPicture;
        private PictureBox pictureBox;
        private Label label2;
        private TextBox textBoxDescription;
        private Button buttonConfirm;
        private TextBox textBoxName;
        private Label label1;
    }
}