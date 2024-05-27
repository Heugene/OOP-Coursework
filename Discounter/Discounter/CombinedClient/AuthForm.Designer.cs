namespace CombinedClient
{
    partial class AuthForm
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
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            textBoxLogin = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            ButtonAuthorize = new Button();
            checkBoxShowPassword = new CheckBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 164);
            label1.Name = "label1";
            label1.Size = new Size(60, 25);
            label1.TabIndex = 0;
            label1.Text = "Логін:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 238);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 1;
            label2.Text = "Пароль:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(322, 142);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ви:";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(63, 81);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(204, 29);
            radioButton2.TabIndex = 1;
            radioButton2.Text = "Менеджер магазину";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(63, 46);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(154, 29);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Адміністратор";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(12, 192);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(322, 31);
            textBoxLogin.TabIndex = 3;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(12, 266);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(322, 31);
            maskedTextBox1.TabIndex = 4;
            maskedTextBox1.UseSystemPasswordChar = true;
            // 
            // ButtonAuthorize
            // 
            ButtonAuthorize.Location = new Point(222, 312);
            ButtonAuthorize.Name = "ButtonAuthorize";
            ButtonAuthorize.Size = new Size(112, 34);
            ButtonAuthorize.TabIndex = 6;
            ButtonAuthorize.Text = "Увійти";
            ButtonAuthorize.UseVisualStyleBackColor = true;
            ButtonAuthorize.Click += ButtonAuthorize_Click;
            // 
            // checkBoxShowPassword
            // 
            checkBoxShowPassword.AutoSize = true;
            checkBoxShowPassword.Location = new Point(12, 312);
            checkBoxShowPassword.Name = "checkBoxShowPassword";
            checkBoxShowPassword.Size = new Size(178, 29);
            checkBoxShowPassword.TabIndex = 7;
            checkBoxShowPassword.Text = "Показати пароль";
            checkBoxShowPassword.UseVisualStyleBackColor = true;
            checkBoxShowPassword.CheckedChanged += checkBoxShowPassword_CheckedChanged;
            // 
            // AuthForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(356, 356);
            Controls.Add(checkBoxShowPassword);
            Controls.Add(ButtonAuthorize);
            Controls.Add(maskedTextBox1);
            Controls.Add(textBoxLogin);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AuthForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Авторизація";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TextBox textBoxLogin;
        private MaskedTextBox maskedTextBox1;
        private Button ButtonAuthorize;
        private CheckBox checkBoxShowPassword;
    }
}