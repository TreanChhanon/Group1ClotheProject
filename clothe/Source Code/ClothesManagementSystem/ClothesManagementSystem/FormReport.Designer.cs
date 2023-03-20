namespace ClothesManagementSystem
{
    partial class FormReport
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
            this.btnPaymentReport = new System.Windows.Forms.Button();
            this.btnOrderedReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPaymentReport
            // 
            this.btnPaymentReport.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPaymentReport.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnPaymentReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btnPaymentReport.FlatAppearance.BorderSize = 0;
            this.btnPaymentReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPaymentReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPaymentReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaymentReport.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaymentReport.ForeColor = System.Drawing.Color.Gold;
            this.btnPaymentReport.Location = new System.Drawing.Point(205, 224);
            this.btnPaymentReport.Name = "btnPaymentReport";
            this.btnPaymentReport.Size = new System.Drawing.Size(207, 41);
            this.btnPaymentReport.TabIndex = 17;
            this.btnPaymentReport.Text = "Payment Report";
            this.btnPaymentReport.UseVisualStyleBackColor = false;
            // 
            // btnOrderedReport
            // 
            this.btnOrderedReport.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOrderedReport.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnOrderedReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btnOrderedReport.FlatAppearance.BorderSize = 0;
            this.btnOrderedReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnOrderedReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnOrderedReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderedReport.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderedReport.ForeColor = System.Drawing.Color.Gold;
            this.btnOrderedReport.Location = new System.Drawing.Point(485, 224);
            this.btnOrderedReport.Name = "btnOrderedReport";
            this.btnOrderedReport.Size = new System.Drawing.Size(207, 41);
            this.btnOrderedReport.TabIndex = 18;
            this.btnOrderedReport.Text = "Ordered Report";
            this.btnOrderedReport.UseVisualStyleBackColor = false;
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(964, 472);
            this.Controls.Add(this.btnOrderedReport);
            this.Controls.Add(this.btnPaymentReport);
            this.Name = "FormReport";
            this.Text = "Report";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPaymentReport;
        private System.Windows.Forms.Button btnOrderedReport;
    }
}