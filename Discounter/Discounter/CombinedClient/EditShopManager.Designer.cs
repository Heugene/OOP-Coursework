namespace CombinedClient
{
    partial class EditShopManager
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
            textBoxPassword = new TextBox();
            label4 = new Label();
            textBoxEmail = new TextBox();
            label3 = new Label();
            maskedTextBoxPhone = new MaskedTextBox();
            label2 = new Label();
            textBoxName = new TextBox();
            label1 = new Label();
            buttonConfirm = new Button();
            SuspendLayout();
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(12, 271);
            textBoxPassword.MaxLength = 12;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(402, 31);
            textBoxPassword.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 243);
            label4.Name = "label4";
            label4.Size = new Size(74, 25);
            label4.TabIndex = 17;
            label4.Text = "Пароль";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(12, 195);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(402, 31);
            textBoxEmail.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 167);
            label3.Name = "label3";
            label3.Size = new Size(162, 25);
            label3.TabIndex = 15;
            label3.Text = "Електронна пошта";
            // 
            // maskedTextBoxPhone
            // 
            maskedTextBoxPhone.Location = new Point(12, 120);
            maskedTextBoxPhone.Mask = "+000000000000";
            maskedTextBoxPhone.Name = "maskedTextBoxPhone";
            maskedTextBoxPhone.Size = new Size(402, 31);
            maskedTextBoxPhone.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 92);
            label2.Name = "label2";
            label2.Size = new Size(81, 25);
            label2.TabIndex = 13;
            label2.Text = "Телефон";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(12, 45);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(402, 31);
            textBoxName.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(40, 25);
            label1.TabIndex = 11;
            label1.Text = "ПІБ";
            // 
            // buttonConfirm
            // 
            buttonConfirm.Location = new Point(154, 318);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(112, 34);
            buttonConfirm.TabIndex = 19;
            buttonConfirm.Text = "Зберегти";
            buttonConfirm.UseVisualStyleBackColor = true;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // EditShopManager
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 374);
            Controls.Add(buttonConfirm);
            Controls.Add(textBoxPassword);
            Controls.Add(label4);
            Controls.Add(textBoxEmail);
            Controls.Add(label3);
            Controls.Add(maskedTextBoxPhone);
            Controls.Add(label2);
            Controls.Add(textBoxName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimumSize = new Size(460, 430);
            Name = "EditShopManager";
            StartPosition = FormStartPosition.CenterParent;
            Text = "EditShopManager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxPassword;
        private Label label4;
        private TextBox textBoxEmail;
        private Label label3;
        private MaskedTextBox maskedTextBoxPhone;
        private Label label2;
        private TextBox textBoxName;
        private Label label1;
        private Button buttonConfirm;
    }
}