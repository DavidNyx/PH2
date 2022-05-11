namespace PH2
{
    partial class HSBN
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
            this.dgv_BNlist = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Return = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BNlist)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_BNlist
            // 
            this.dgv_BNlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BNlist.Location = new System.Drawing.Point(112, 113);
            this.dgv_BNlist.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_BNlist.Name = "dgv_BNlist";
            this.dgv_BNlist.RowHeadersWidth = 51;
            this.dgv_BNlist.Size = new System.Drawing.Size(840, 364);
            this.dgv_BNlist.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.Location = new System.Drawing.Point(278, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 46);
            this.label1.TabIndex = 14;
            this.label1.Text = "THÔNG TIN BỆNH NHÂN";
            // 
            // btn_Return
            // 
            this.btn_Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Return.Location = new System.Drawing.Point(359, 492);
            this.btn_Return.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(331, 50);
            this.btn_Return.TabIndex = 15;
            this.btn_Return.Text = "Quay lại";
            this.btn_Return.UseVisualStyleBackColor = true;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // HSBN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btn_Return);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_BNlist);
            this.Name = "HSBN";
            this.Text = "HSBN";
            this.Load += new System.EventHandler(this.HSBN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BNlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_BNlist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Return;
    }
}