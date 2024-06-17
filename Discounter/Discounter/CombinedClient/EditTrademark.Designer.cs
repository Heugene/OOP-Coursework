namespace CombinedClient
{
    partial class EditTrademark
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
            buttonConfirm = new Button();
            textBoxDescription = new TextBox();
            textBoxName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonConfirm
            // 
            buttonConfirm.Location = new Point(229, 363);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(112, 34);
            buttonConfirm.TabIndex = 9;
            buttonConfirm.Text = "Зберегти";
            buttonConfirm.UseVisualStyleBackColor = true;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(12, 127);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.ScrollBars = ScrollBars.Vertical;
            textBoxDescription.Size = new Size(537, 217);
            textBoxDescription.TabIndex = 8;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(12, 38);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(537, 31);
            textBoxName.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 99);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 6;
            label2.Text = "Опис";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(61, 25);
            label1.TabIndex = 5;
            label1.Text = "Назва";
            // 
            // EditTrademark
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 404);
            Controls.Add(buttonConfirm);
            Controls.Add(textBoxDescription);
            Controls.Add(textBoxName);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimumSize = new Size(600, 460);
            Name = "EditTrademark";
            StartPosition = FormStartPosition.CenterParent;
            Text = "EditTrademark";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonConfirm;
        private TextBox textBoxDescription;
        private TextBox textBoxName;
        private Label label2;
        private Label label1;
    }
}