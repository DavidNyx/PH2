namespace PH2
{
    partial class XemTTBN
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
            this.dgv_BNlist = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_CMND = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BNlist)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(209, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "THÔNG TIN BỆNH NHÂN";
            // 
            // dgv_BNlist
            // 
            this.dgv_BNlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BNlist.Location = new System.Drawing.Point(85, 91);
            this.dgv_BNlist.Name = "dgv_BNlist";
            this.dgv_BNlist.Size = new System.Drawing.Size(630, 296);
            this.dgv_BNlist.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mã bệnh nhân/CMND";
            // 
            // txt_CMND
            // 
            this.txt_CMND.Location = new System.Drawing.Point(525, 64);
            this.txt_CMND.Name = "txt_CMND";
            this.txt_CMND.Size = new System.Drawing.Size(137, 20);
            this.txt_CMND.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(668, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Xem";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // XemTTBN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_CMND);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Return);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_BNlist);
            this.Name = "XemTTBN";
            this.Text = "XemTTBN";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BNlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Return;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_BNlist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_CMND;
        private System.Windows.Forms.Button button1;
    }
}