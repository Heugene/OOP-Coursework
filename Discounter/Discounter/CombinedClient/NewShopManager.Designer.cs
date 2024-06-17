namespace CombinedClient
{
    partial class NewShopManager
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
            textBoxName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            maskedTextBoxPhone = new MaskedTextBox();
            textBoxEmail = new TextBox();
            label3 = new Label();
            textBoxPassword = new TextBox();
            label4 = new Label();
            comboBoxTrademark = new ComboBox();
            label5 = new Label();
            dataGridView = new DataGridView();
            label6 = new Label();
            buttonCreate = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(12, 38);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(568, 31);
            textBoxName.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(40, 25);
            label1.TabIndex = 3;
            label1.Text = "ПІБ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 85);
            label2.Name = "label2";
            label2.Size = new Size(81, 25);
            label2.TabIndex = 5;
            label2.Text = "Телефон";
            // 
            // maskedTextBoxPhone
            // 
            maskedTextBoxPhone.Location = new Point(12, 113);
            maskedTextBoxPhone.Mask = "+000000000000";
            maskedTextBoxPhone.Name = "maskedTextBoxPhone";
            maskedTextBoxPhone.Size = new Size(239, 31);
            maskedTextBoxPhone.TabIndex = 6;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(267, 113);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(313, 31);
            textBoxEmail.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(267, 85);
            label3.Name = "label3";
            label3.Size = new Size(162, 25);
            label3.TabIndex = 7;
            label3.Text = "Електронна пошта";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(12, 192);
            textBoxPassword.MaxLength = 12;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(239, 31);
            textBoxPassword.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 164);
            label4.Name = "label4";
            label4.Size = new Size(74, 25);
            label4.TabIndex = 9;
            label4.Text = "Пароль";
            // 
            // comboBoxTrademark
            // 
            comboBoxTrademark.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTrademark.FormattingEnabled = true;
            comboBoxTrademark.Items.AddRange(new object[] { "-Оберіть торгову марку-" });
            comboBoxTrademark.Location = new Point(267, 190);
            comboBoxTrademark.Name = "comboBoxTrademark";
            comboBoxTrademark.Size = new Size(313, 33);
            comboBoxTrademark.TabIndex = 11;
            comboBoxTrademark.SelectedIndexChanged += comboBoxTrademark_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(267, 162);
            label5.Name = "label5";
            label5.Size = new Size(245, 25);
            label5.TabIndex = 12;
            label5.Text = "Відобразити магазини за ТМ";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(12, 276);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 62;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(568, 197);
            dataGridView.TabIndex = 17;
            dataGridView.SelectionChanged += dataGridView_SelectionChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 238);
            label6.Name = "label6";
            label6.Size = new Size(81, 25);
            label6.TabIndex = 16;
            label6.Text = "Магазин";
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(235, 491);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(112, 34);
            buttonCreate.TabIndex = 18;
            buttonCreate.Text = "Створити";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // NewShopManager
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 534);
            Controls.Add(buttonCreate);
            Controls.Add(dataGridView);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(comboBoxTrademark);
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
            MinimumSize = new Size(620, 590);
            Name = "NewShopManager";
            StartPosition = FormStartPosition.CenterParent;
            Text = "NewShopManager";
            Load += NewShopManager_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private Label label1;
        private Label label2;
        private MaskedTextBox maskedTextBoxPhone;
        private TextBox textBoxEmail;
        private Label label3;
        private TextBox textBoxPassword;
        private Label label4;
        private ComboBox comboBoxTrademark;
        private Label label5;
        private DataGridView dataGridView;
        private Label label6;
        private Button buttonCreate;
    }
}