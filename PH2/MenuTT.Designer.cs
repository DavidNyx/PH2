
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
            this.Returnbtn = new System.Windows.Forms.Button();
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
            // Select_NVbtn
            // 
            this.Select_NVbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Select_NVbtn.Location = new System.Drawing.Point(180, 88);
            this.Select_NVbtn.Margin = new System.Windows.Forms.Padding(2);
            this.Select_NVbtn.Name = "Select_NVbtn";
            this.Select_NVbtn.Size = new System.Drawing.Size(248, 41);
            this.Select_NVbtn.TabIndex = 1;
            this.Select_NVbtn.Text = "Xem thông tin nhân viên";
            this.Select_NVbtn.UseVisualStyleBackColor = true;
            // 
            // Select_BNbtn
            // 
            this.Select_BNbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Select_BNbtn.Location = new System.Drawing.Point(180, 149);
            this.Select_BNbtn.Margin = new System.Windows.Forms.Padding(2);
            this.Select_BNbtn.Name = "Select_BNbtn";
            this.Select_BNbtn.Size = new System.Drawing.Size(248, 41);
            this.Select_BNbtn.TabIndex = 2;
            this.Select_BNbtn.Text = "Xem thông tin bệnh nhân";
            this.Select_BNbtn.UseVisualStyleBackColor = true;
            // 
            // Select_HSBAbtn
            // 
            this.Select_HSBAbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Select_HSBAbtn.Location = new System.Drawing.Point(180, 212);
            this.Select_HSBAbtn.Margin = new System.Windows.Forms.Padding(2);
            this.Select_HSBAbtn.Name = "Select_HSBAbtn";
            this.Select_HSBAbtn.Size = new System.Drawing.Size(248, 41);
            this.Select_HSBAbtn.TabIndex = 3;
            this.Select_HSBAbtn.Text = "Xem thông tin hồ sơ bệnh án";
            this.Select_HSBAbtn.UseVisualStyleBackColor = true;
            this.Select_HSBAbtn.Click += new System.EventHandler(this.Select_HSBAbtn_Click);
            // 
            // Returnbtn
            // 
            this.Returnbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Returnbtn.Location = new System.Drawing.Point(180, 274);
            this.Returnbtn.Margin = new System.Windows.Forms.Padding(2);
            this.Returnbtn.Name = "Returnbtn";
            this.Returnbtn.Size = new System.Drawing.Size(248, 41);
            this.Returnbtn.TabIndex = 5;
            this.Returnbtn.Text = "Quay lại";
            this.Returnbtn.UseVisualStyleBackColor = true;
            this.Returnbtn.Click += new System.EventHandler(this.Returnbtn_Click);
            // 
            // MenuTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.Returnbtn);
            this.Controls.Add(this.Select_HSBAbtn);
            this.Controls.Add(this.Select_BNbtn);
            this.Controls.Add(this.Select_NVbtn);
            this.Controls.Add(this.Menu);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Button Returnbtn;
    }
}