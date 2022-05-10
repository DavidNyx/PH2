
namespace PH2
{
    partial class MenuTT
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
            this.Menu = new System.Windows.Forms.Label();
            this.btn_Select_NV = new System.Windows.Forms.Button();
            this.btn_Select_BN = new System.Windows.Forms.Button();
            this.btn_Select_HSBA = new System.Windows.Forms.Button();
            this.btn_Return = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.AutoSize = true;
            this.Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu.Location = new System.Drawing.Point(262, 7);
            this.Menu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(96, 37);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "Menu";
            // 
            // btn_Select_NV
            // 
            this.btn_Select_NV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Select_NV.Location = new System.Drawing.Point(180, 88);
            this.btn_Select_NV.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Select_NV.Name = "btn_Select_NV";
            this.btn_Select_NV.Size = new System.Drawing.Size(248, 41);
            this.btn_Select_NV.TabIndex = 1;
            this.btn_Select_NV.Text = "Xem thông tin nhân viên";
            this.btn_Select_NV.UseVisualStyleBackColor = true;
            this.btn_Select_NV.Click += new System.EventHandler(this.btn_Select_NV_Click);
            // 
            // btn_Select_BN
            // 
            this.btn_Select_BN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Select_BN.Location = new System.Drawing.Point(180, 149);
            this.btn_Select_BN.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Select_BN.Name = "btn_Select_BN";
            this.btn_Select_BN.Size = new System.Drawing.Size(248, 41);
            this.btn_Select_BN.TabIndex = 2;
            this.btn_Select_BN.Text = "Xem thông tin bệnh nhân";
            this.btn_Select_BN.UseVisualStyleBackColor = true;
            this.btn_Select_BN.Click += new System.EventHandler(this.btn_Select_BN_Click);
            // 
            // btn_Select_HSBA
            // 
            this.btn_Select_HSBA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btn_Select_HSBA.Location = new System.Drawing.Point(180, 212);
            this.btn_Select_HSBA.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Select_HSBA.Name = "btn_Select_HSBA";
            this.btn_Select_HSBA.Size = new System.Drawing.Size(248, 41);
            this.btn_Select_HSBA.TabIndex = 3;
            this.btn_Select_HSBA.Text = "Xem thông tin hồ sơ bệnh án";
            this.btn_Select_HSBA.UseVisualStyleBackColor = true;
            this.btn_Select_HSBA.Click += new System.EventHandler(this.btn_Select_HSBA_Click);
            // 
            // btn_Return
            // 
            this.btn_Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Return.Location = new System.Drawing.Point(180, 274);
            this.btn_Return.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(248, 41);
            this.btn_Return.TabIndex = 5;
            this.btn_Return.Text = "Quay lại";
            this.btn_Return.UseVisualStyleBackColor = true;
            this.btn_Return.Click += new System.EventHandler(this.Returnbtn_Click);
            // 
            // MenuTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btn_Return);
            this.Controls.Add(this.btn_Select_HSBA);
            this.Controls.Add(this.btn_Select_BN);
            this.Controls.Add(this.btn_Select_NV);
            this.Controls.Add(this.Menu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MenuTT";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Menu;
        private System.Windows.Forms.Button btn_Select_NV;
        private System.Windows.Forms.Button btn_Select_BN;
        private System.Windows.Forms.Button btn_Select_HSBA;
        private System.Windows.Forms.Button btn_Return;
    }
}