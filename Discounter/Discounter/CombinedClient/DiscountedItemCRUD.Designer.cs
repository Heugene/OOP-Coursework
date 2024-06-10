namespace CombinedClient
{
    partial class DiscountedItemCRUD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiscountedItemCRUD));
            dataGridView = new DataGridView();
            toolStrip = new ToolStrip();
            toolStripButtonRefresh = new ToolStripButton();
            toolStripButtonNew = new ToolStripButton();
            toolStripButtonEdit = new ToolStripButton();
            toolStripButtonDelete = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            toolStrip.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(0, 34);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 62;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(778, 510);
            dataGridView.TabIndex = 5;
            dataGridView.SelectionChanged += dataGridView_SelectionChanged;
            // 
            // toolStrip
            // 
            toolStrip.ImageScalingSize = new Size(24, 24);
            toolStrip.Items.AddRange(new ToolStripItem[] { toolStripButtonRefresh, toolStripButtonNew, toolStripButtonEdit, toolStripButtonDelete });
            toolStrip.Location = new Point(0, 0);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(778, 34);
            toolStrip.TabIndex = 4;
            toolStrip.Text = "toolStrip";
            // 
            // toolStripButtonRefresh
            // 
            toolStripButtonRefresh.Image = (Image)resources.GetObject("toolStripButtonRefresh.Image");
            toolStripButtonRefresh.ImageTransparentColor = Color.Magenta;
            toolStripButtonRefresh.Name = "toolStripButtonRefresh";
            toolStripButtonRefresh.Size = new Size(112, 29);
            toolStripButtonRefresh.Text = "Оновити";
            toolStripButtonRefresh.Click += toolStripButtonRefresh_Click;
            // 
            // toolStripButtonNew
            // 
            toolStripButtonNew.Image = (Image)resources.GetObject("toolStripButtonNew.Image");
            toolStripButtonNew.ImageTransparentColor = Color.Magenta;
            toolStripButtonNew.Name = "toolStripButtonNew";
            toolStripButtonNew.Size = new Size(125, 29);
            toolStripButtonNew.Text = "Створити..";
            toolStripButtonNew.Click += toolStripButtonNew_Click;
            // 
            // toolStripButtonEdit
            // 
            toolStripButtonEdit.Enabled = false;
            toolStripButtonEdit.Image = (Image)resources.GetObject("toolStripButtonEdit.Image");
            toolStripButtonEdit.ImageTransparentColor = Color.Magenta;
            toolStripButtonEdit.Name = "toolStripButtonEdit";
            toolStripButtonEdit.Size = new Size(138, 29);
            toolStripButtonEdit.Text = "Редагувати..";
            toolStripButtonEdit.Click += toolStripButtonEdit_Click;
            // 
            // toolStripButtonDelete
            // 
            toolStripButtonDelete.Enabled = false;
            toolStripButtonDelete.Image = (Image)resources.GetObject("toolStripButtonDelete.Image");
            toolStripButtonDelete.ImageTransparentColor = Color.Magenta;
            toolStripButtonDelete.Name = "toolStripButtonDelete";
            toolStripButtonDelete.Size = new Size(115, 29);
            toolStripButtonDelete.Text = "Видалити";
            toolStripButtonDelete.Click += toolStripButtonDelete_Click;
            // 
            // DiscountedItemCRUD
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 544);
            Controls.Add(dataGridView);
            Controls.Add(toolStrip);
            MinimumSize = new Size(800, 600);
            Name = "DiscountedItemCRUD";
            StartPosition = FormStartPosition.CenterParent;
            Text = "DiscountedItemCRUD";
            Load += DiscountedItemCRUD_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private ToolStrip toolStrip;
        private ToolStripButton toolStripButtonRefresh;
        private ToolStripButton toolStripButtonNew;
        private ToolStripButton toolStripButtonEdit;
        private ToolStripButton toolStripButtonDelete;
    }
}