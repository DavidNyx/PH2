namespace PH2
{
    partial class XemHSBA
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
            this.btn_Return = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_HSlist = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HSlist)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Return
            // 
            this.btn_Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Return.Location = new System.Drawing.Point(270, 399);
            this.btn_Return.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(248, 41);
            this.btn_Return.TabIndex = 9;
            this.btn_Return.Text = "Quay lại";
            this.btn_Return.UseVisualStyleBackColor = true;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.Location = new System.Drawing.Point(165, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "DANH SÁCH HỒ SƠ BỆNH ÁN";
            // 
            // dgv_HSlist
            // 
            this.dgv_HSlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HSlist.Location = new System.Drawing.Point(85, 64);
            this.dgv_HSlist.Name = "dgv_HSlist";
            this.dgv_HSlist.Size = new System.Drawing.Size(630, 323);
            this.dgv_HSlist.TabIndex = 7;
            this.dgv_HSlist.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_HSlist_CellDoubleClick);
            // 
            // XemHSBA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Return);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_HSlist);
            this.Name = "XemHSBA";
            this.Text = "XemHSBA";
            this.Load += new System.EventHandler(this.XemHSBA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HSlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Return;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_HSlist;
    }
}