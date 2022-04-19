
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
            this.Select_NVbtn = new System.Windows.Forms.Button();
            this.Select_BNbtn = new System.Windows.Forms.Button();
            this.Select_HSBAbtn = new System.Windows.Forms.Button();
            this.Select_HSBA_DVbtn = new System.Windows.Forms.Button();
            this.Returnbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.AutoSize = true;
            this.Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu.Location = new System.Drawing.Point(350, 9);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(119, 46);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "Menu";
            // 
            // Select_NVbtn
            // 
            this.Select_NVbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Select_NVbtn.Location = new System.Drawing.Point(240, 80);
            this.Select_NVbtn.Name = "Select_NVbtn";
            this.Select_NVbtn.Size = new System.Drawing.Size(330, 50);
            this.Select_NVbtn.TabIndex = 1;
            this.Select_NVbtn.Text = "Xem thông tin nhân viên";
            this.Select_NVbtn.UseVisualStyleBackColor = true;
            // 
            // Select_BNbtn
            // 
            this.Select_BNbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Select_BNbtn.Location = new System.Drawing.Point(240, 150);
            this.Select_BNbtn.Name = "Select_BNbtn";
            this.Select_BNbtn.Size = new System.Drawing.Size(330, 50);
            this.Select_BNbtn.TabIndex = 2;
            this.Select_BNbtn.Text = "Xem thông tin bệnh nhân";
            this.Select_BNbtn.UseVisualStyleBackColor = true;
            // 
            // Select_HSBAbtn
            // 
            this.Select_HSBAbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Select_HSBAbtn.Location = new System.Drawing.Point(240, 220);
            this.Select_HSBAbtn.Name = "Select_HSBAbtn";
            this.Select_HSBAbtn.Size = new System.Drawing.Size(330, 50);
            this.Select_HSBAbtn.TabIndex = 3;
            this.Select_HSBAbtn.Text = "Xem thông tin hồ sơ bệnh án";
            this.Select_HSBAbtn.UseVisualStyleBackColor = true;
            // 
            // Select_HSBA_DVbtn
            // 
            this.Select_HSBA_DVbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Select_HSBA_DVbtn.Location = new System.Drawing.Point(240, 290);
            this.Select_HSBA_DVbtn.Name = "Select_HSBA_DVbtn";
            this.Select_HSBA_DVbtn.Size = new System.Drawing.Size(330, 50);
            this.Select_HSBA_DVbtn.TabIndex = 4;
            this.Select_HSBA_DVbtn.Text = "Xem thông tin HSBA dịch vụ";
            this.Select_HSBA_DVbtn.UseVisualStyleBackColor = true;
            // 
            // Returnbtn
            // 
            this.Returnbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Returnbtn.Location = new System.Drawing.Point(240, 360);
            this.Returnbtn.Name = "Returnbtn";
            this.Returnbtn.Size = new System.Drawing.Size(330, 50);
            this.Returnbtn.TabIndex = 5;
            this.Returnbtn.Text = "Quay lại";
            this.Returnbtn.UseVisualStyleBackColor = true;
            this.Returnbtn.Click += new System.EventHandler(this.Returnbtn_Click);
            // 
            // MenuTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Returnbtn);
            this.Controls.Add(this.Select_HSBA_DVbtn);
            this.Controls.Add(this.Select_HSBAbtn);
            this.Controls.Add(this.Select_BNbtn);
            this.Controls.Add(this.Select_NVbtn);
            this.Controls.Add(this.Menu);
            this.Name = "MenuTT";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Menu;
        private System.Windows.Forms.Button Select_NVbtn;
        private System.Windows.Forms.Button Select_BNbtn;
        private System.Windows.Forms.Button Select_HSBAbtn;
        private System.Windows.Forms.Button Select_HSBA_DVbtn;
        private System.Windows.Forms.Button Returnbtn;
    }
}