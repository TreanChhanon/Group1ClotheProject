namespace oracle_project
{
    partial class FormRestoreProduct
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRestoreProduct));
			this.btnRestoreAll = new System.Windows.Forms.Button();
			this.btnRestore = new System.Windows.Forms.Button();
			this.dgvProduct = new System.Windows.Forms.DataGridView();
			this.btnBack = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
			this.SuspendLayout();
			// 
			// btnRestoreAll
			// 
			this.btnRestoreAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRestoreAll.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRestoreAll.Location = new System.Drawing.Point(1028, 114);
			this.btnRestoreAll.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.btnRestoreAll.Name = "btnRestoreAll";
			this.btnRestoreAll.Size = new System.Drawing.Size(125, 42);
			this.btnRestoreAll.TabIndex = 41;
			this.btnRestoreAll.Text = "Restore All";
			this.btnRestoreAll.UseVisualStyleBackColor = true;
			this.btnRestoreAll.Click += new System.EventHandler(this.BtnRestoreAll_Click);
			// 
			// btnRestore
			// 
			this.btnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRestore.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRestore.Location = new System.Drawing.Point(847, 117);
			this.btnRestore.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.btnRestore.Name = "btnRestore";
			this.btnRestore.Size = new System.Drawing.Size(125, 42);
			this.btnRestore.TabIndex = 40;
			this.btnRestore.Text = "Restore";
			this.btnRestore.UseVisualStyleBackColor = true;
			this.btnRestore.Click += new System.EventHandler(this.BtnRestore_Click);
			// 
			// dgvProduct
			// 
			this.dgvProduct.AllowUserToAddRows = false;
			this.dgvProduct.AllowUserToDeleteRows = false;
			this.dgvProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvProduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProduct.GridColor = System.Drawing.Color.DarkGray;
			this.dgvProduct.Location = new System.Drawing.Point(39, 248);
			this.dgvProduct.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.dgvProduct.Name = "dgvProduct";
			this.dgvProduct.ReadOnly = true;
			this.dgvProduct.RowHeadersWidth = 51;
			this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvProduct.Size = new System.Drawing.Size(1273, 293);
			this.dgvProduct.TabIndex = 37;
			this.dgvProduct.Click += new System.EventHandler(this.DgvProduct_Click);
			// 
			// btnBack
			// 
			this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBack.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBack.Location = new System.Drawing.Point(1187, 117);
			this.btnBack.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(125, 42);
			this.btnBack.TabIndex = 45;
			this.btnBack.Text = "Back";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
			// 
			// FormRestoreProduct
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1351, 569);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.btnRestoreAll);
			this.Controls.Add(this.btnRestore);
			this.Controls.Add(this.dgvProduct);
			this.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.Name = "FormRestoreProduct";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Restore Product Management System";
			this.Load += new System.EventHandler(this.FormRestoreProduct_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRestoreAll;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Button btnBack;
    }
}