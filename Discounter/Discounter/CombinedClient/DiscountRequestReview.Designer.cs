namespace CombinedClient
{
    partial class DiscountRequestReview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiscountRequestReview));
            dataGridView = new DataGridView();
            toolStrip = new ToolStrip();
            toolStripButtonRefresh = new ToolStripButton();
            toolStripButtonApprove = new ToolStripButton();
            toolStripButtonReject = new ToolStripButton();
            toolStripButtonApproveAll = new ToolStripButton();
            toolStripButtonRejectAll = new ToolStripButton();
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
            dataGridView.CellDoubleClick += dataGridView_CellDoubleClick;
            dataGridView.SelectionChanged += dataGridView_SelectionChanged;
            // 
            // toolStrip
            // 
            toolStrip.ImageScalingSize = new Size(24, 24);
            toolStrip.Items.AddRange(new ToolStripItem[] { toolStripButtonRefresh, toolStripButtonApprove, toolStripButtonReject, toolStripButtonApproveAll, toolStripButtonRejectAll });
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
            // toolStripButtonApprove
            // 
            toolStripButtonApprove.Image = (Image)resources.GetObject("toolStripButtonApprove.Image");
            toolStripButtonApprove.ImageTransparentColor = Color.Magenta;
            toolStripButtonApprove.Name = "toolStripButtonApprove";
            toolStripButtonApprove.Size = new Size(114, 29);
            toolStripButtonApprove.Text = "Схвалити";
            toolStripButtonApprove.Click += toolStripButtonApprove_Click;
            // 
            // toolStripButtonReject
            // 
            toolStripButtonReject.Enabled = false;
            toolStripButtonReject.Image = (Image)resources.GetObject("toolStripButtonReject.Image");
            toolStripButtonReject.ImageTransparentColor = Color.Magenta;
            toolStripButtonReject.Name = "toolStripButtonReject";
            toolStripButtonReject.Size = new Size(118, 29);
            toolStripButtonReject.Text = "Відхилити";
            toolStripButtonReject.Click += toolStripButtonReject_Click;
            // 
            // toolStripButtonApproveAll
            // 
            toolStripButtonApproveAll.Enabled = false;
            toolStripButtonApproveAll.Image = (Image)resources.GetObject("toolStripButtonApproveAll.Image");
            toolStripButtonApproveAll.ImageTransparentColor = Color.Magenta;
            toolStripButtonApproveAll.Name = "toolStripButtonApproveAll";
            toolStripButtonApproveAll.Size = new Size(146, 29);
            toolStripButtonApproveAll.Text = "Схвалити все";
            toolStripButtonApproveAll.Click += toolStripButtonApproveAll_Click;
            // 
            // toolStripButtonRejectAll
            // 
            toolStripButtonRejectAll.Image = (Image)resources.GetObject("toolStripButtonRejectAll.Image");
            toolStripButtonRejectAll.ImageTransparentColor = Color.Magenta;
            toolStripButtonRejectAll.Name = "toolStripButtonRejectAll";
            toolStripButtonRejectAll.Size = new Size(150, 29);
            toolStripButtonRejectAll.Text = "Відхилити все";
            toolStripButtonRejectAll.Click += toolStripButtonRejectAll_Click;
            // 
            // DiscountRequestReview
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 544);
            Controls.Add(dataGridView);
            Controls.Add(toolStrip);
            MinimumSize = new Size(800, 600);
            Name = "DiscountRequestReview";
            StartPosition = FormStartPosition.CenterParent;
            Text = "DiscountRequestReview";
            Load += DiscountRequestReview_Load;
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
        private ToolStripButton toolStripButtonApprove;
        private ToolStripButton toolStripButtonReject;
        private ToolStripButton toolStripButtonApproveAll;
        private ToolStripButton toolStripButtonRejectAll;
    }
}