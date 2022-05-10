namespace PH2
{
    partial class XemTTNV
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
            this.dgv_NVlist = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_return = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NVlist)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_NVlist
            // 
            this.dgv_NVlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NVlist.Location = new System.Drawing.Point(82, 63);
            this.dgv_NVlist.Name = "dgv_NVlist";
            this.dgv_NVlist.Size = new System.Drawing.Size(630, 323);
            this.dgv_NVlist.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.Location = new System.Drawing.Point(206, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH NHÂN VIÊN";
            // 
            // btn_return
            // 
            this.btn_return.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_return.Location = new System.Drawing.Point(267, 398);
            this.btn_return.Margin = new System.Windows.Forms.Padding(2);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(248, 41);
            this.btn_return.TabIndex = 6;
            this.btn_return.Text = "Quay lại";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // XemTTNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_NVlist);
            this.Name = "XemTTNV";
            this.Text = "XemTTNV";
            this.Load += new System.EventHandler(this.XemTTNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NVlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_NVlist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_return;
    }
}