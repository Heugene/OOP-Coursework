namespace CombinedClient
{
    partial class NewDiscount
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
            buttonCreate = new Button();
            dataGridView = new DataGridView();
            label6 = new Label();
            textBoxName = new TextBox();
            label1 = new Label();
            textBoxDescription = new TextBox();
            label2 = new Label();
            numericUpDownOldPrice = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            numericUpDownNewPrice = new NumericUpDown();
            dateTimePickerStart = new DateTimePicker();
            label5 = new Label();
            label7 = new Label();
            dateTimePickerEnd = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownOldPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNewPrice).BeginInit();
            SuspendLayout();
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(233, 629);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(112, 34);
            buttonCreate.TabIndex = 23;
            buttonCreate.Text = "Створити";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(12, 415);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 62;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(568, 197);
            dataGridView.TabIndex = 22;
            dataGridView.SelectionChanged += dataGridView_SelectionChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 377);
            label6.Name = "label6";
            label6.Size = new Size(252, 25);
            label6.TabIndex = 21;
            label6.Text = "Предмет акційної пропозиції";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(12, 37);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(568, 31);
            textBoxName.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(61, 25);
            label1.TabIndex = 19;
            label1.Text = "Назва";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(12, 109);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.ScrollBars = ScrollBars.Vertical;
            textBoxDescription.Size = new Size(263, 150);
            textBoxDescription.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 81);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 26;
            label2.Text = "Опис";
            // 
            // numericUpDownOldPrice
            // 
            numericUpDownOldPrice.DecimalPlaces = 2;
            numericUpDownOldPrice.Location = new Point(325, 110);
            numericUpDownOldPrice.Maximum = new decimal(new int[] { 276447231, 23283, 0, 0 });
            numericUpDownOldPrice.Name = "numericUpDownOldPrice";
            numericUpDownOldPrice.Size = new Size(255, 31);
            numericUpDownOldPrice.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(325, 82);
            label3.Name = "label3";
            label3.Size = new Size(98, 25);
            label3.TabIndex = 28;
            label3.Text = "Стара ціна";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(325, 157);
            label4.Name = "label4";
            label4.Size = new Size(94, 25);
            label4.TabIndex = 30;
            label4.Text = "Нова ціна";
            // 
            // numericUpDownNewPrice
            // 
            numericUpDownNewPrice.DecimalPlaces = 2;
            numericUpDownNewPrice.Location = new Point(325, 185);
            numericUpDownNewPrice.Maximum = new decimal(new int[] { 276447231, 23283, 0, 0 });
            numericUpDownNewPrice.Name = "numericUpDownNewPrice";
            numericUpDownNewPrice.Size = new Size(255, 31);
            numericUpDownNewPrice.TabIndex = 29;
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dateTimePickerStart.Format = DateTimePickerFormat.Custom;
            dateTimePickerStart.Location = new Point(20, 318);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(255, 31);
            dateTimePickerStart.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 290);
            label5.Name = "label5";
            label5.Size = new Size(119, 25);
            label5.TabIndex = 32;
            label5.Text = "Дата початку";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(325, 290);
            label7.Name = "label7";
            label7.Size = new Size(97, 25);
            label7.TabIndex = 34;
            label7.Text = "Дата кінця";
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dateTimePickerEnd.Format = DateTimePickerFormat.Custom;
            dateTimePickerEnd.Location = new Point(325, 318);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(255, 31);
            dateTimePickerEnd.TabIndex = 33;
            // 
            // NewDiscount
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 674);
            Controls.Add(label7);
            Controls.Add(dateTimePickerEnd);
            Controls.Add(label5);
            Controls.Add(dateTimePickerStart);
            Controls.Add(label4);
            Controls.Add(numericUpDownNewPrice);
            Controls.Add(label3);
            Controls.Add(numericUpDownOldPrice);
            Controls.Add(label2);
            Controls.Add(textBoxDescription);
            Controls.Add(buttonCreate);
            Controls.Add(dataGridView);
            Controls.Add(label6);
            Controls.Add(textBoxName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimumSize = new Size(625, 730);
            Name = "NewDiscount";
            StartPosition = FormStartPosition.CenterParent;
            Text = "NewDiscount";
            Load += NewDiscount_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownOldPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNewPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCreate;
        private DataGridView dataGridView;
        private Label label6;
        private TextBox textBoxName;
        private Label label1;
        private TextBox textBoxDescription;
        private Label label2;
        private NumericUpDown numericUpDownOldPrice;
        private Label label3;
        private Label label4;
        private NumericUpDown numericUpDownNewPrice;
        private DateTimePicker dateTimePickerStart;
        private Label label5;
        private Label label7;
        private DateTimePicker dateTimePickerEnd;
    }
}