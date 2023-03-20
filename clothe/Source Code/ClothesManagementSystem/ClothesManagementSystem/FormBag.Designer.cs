namespace ClothesManagementSystem
{
    partial class FormBag
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
			this.panelDesktop = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panelDesktop.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelDesktop
			// 
			this.panelDesktop.Controls.Add(this.label1);
			this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelDesktop.Location = new System.Drawing.Point(0, 0);
			this.panelDesktop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.panelDesktop.Name = "panelDesktop";
			this.panelDesktop.Size = new System.Drawing.Size(1238, 707);
			this.panelDesktop.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(461, 308);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(269, 48);
			this.label1.TabIndex = 22;
			this.label1.Text = "Coming Soon...";
			// 
			// FormBag
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
			this.ClientSize = new System.Drawing.Size(1238, 707);
			this.Controls.Add(this.panelDesktop);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "FormBag";
			this.Text = "FormBag";
			this.panelDesktop.ResumeLayout(false);
			this.panelDesktop.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDesktop;
		private System.Windows.Forms.Label label1;
	}
}