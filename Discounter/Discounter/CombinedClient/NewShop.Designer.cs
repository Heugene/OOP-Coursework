namespace CombinedClient
{
    partial class NewShop
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
            dataGridView = new DataGridView();
            buttonCreate = new Button();
            textBoxAddress = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(12, 135);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 62;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(537, 197);
            dataGridView.TabIndex = 15;
            dataGridView.SelectionChanged += dataGridView_SelectionChanged;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(222, 351);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(112, 34);
            buttonCreate.TabIndex = 14;
            buttonCreate.Text = "Створити";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(12, 36);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(537, 31);
            textBoxAddress.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 97);
            label2.Name = "label2";
            label2.Size = new Size(136, 25);
            label2.TabIndex = 12;
            label2.Text = "Торгова марка";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(71, 25);
            label1.TabIndex = 11;
            label1.Text = "Адреса";
            // 
            // NewShop
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 404);
            Controls.Add(dataGridView);
            Controls.Add(buttonCreate);
            Controls.Add(textBoxAddress);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimumSize = new Size(600, 460);
            Name = "NewShop";
            StartPosition = FormStartPosition.CenterParent;
            Text = "NewShop";
            Load += NewShop_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private Button buttonCreate;
        private TextBox textBoxAddress;
        private Label label2;
        private Label label1;
    }
}