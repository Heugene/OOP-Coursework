namespace CombinedClient
{
    partial class EditShop
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
            label1 = new Label();
            textBoxAddress = new TextBox();
            SuspendLayout();
            // 
            // buttonConfirm
            // 
            buttonConfirm.Location = new Point(228, 120);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(112, 34);
            buttonConfirm.TabIndex = 9;
            buttonConfirm.Text = "Зберегти";
            buttonConfirm.UseVisualStyleBackColor = true;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(116, 25);
            label1.TabIndex = 5;
            label1.Text = "Нова адреса";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(12, 43);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(537, 31);
            textBoxAddress.TabIndex = 7;
            // 
            // EditShop
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 184);
            Controls.Add(buttonConfirm);
            Controls.Add(textBoxAddress);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimumSize = new Size(600, 240);
            Name = "EditShop";
            StartPosition = FormStartPosition.CenterParent;
            Text = "EditShop";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonConfirm;
        private Label label1;
        private TextBox textBoxAddress;
    }
}