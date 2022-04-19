
namespace PH2
{
    partial class MenuCSYT
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
            this.Insert_HSBAbtn = new System.Windows.Forms.Button();
            this.Menu = new System.Windows.Forms.Label();
            this.Delete_HSBAbtn = new System.Windows.Forms.Button();
            this.Insert_HSBA_DVbtn = new System.Windows.Forms.Button();
            this.Delete_HSBA_DVbtn = new System.Windows.Forms.Button();
            this.Returnbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Insert_HSBAbtn
            // 
            this.Insert_HSBAbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insert_HSBAbtn.Location = new System.Drawing.Point(240, 80);
            this.Insert_HSBAbtn.Name = "Insert_HSBAbtn";
            this.Insert_HSBAbtn.Size = new System.Drawing.Size(330, 50);
            this.Insert_HSBAbtn.TabIndex = 0;
            this.Insert_HSBAbtn.Text = "Thêm hồ sơ bệnh án";
            this.Insert_HSBAbtn.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.Menu.AutoSize = true;
            this.Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu.Location = new System.Drawing.Point(350, 9);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(119, 46);
            this.Menu.TabIndex = 1;
            this.Menu.Text = "Menu";
            // 
            // Delete_HSBAbtn
            // 
            this.Delete_HSBAbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_HSBAbtn.Location = new System.Drawing.Point(240, 150);
            this.Delete_HSBAbtn.Name = "Delete_HSBAbtn";
            this.Delete_HSBAbtn.Size = new System.Drawing.Size(330, 50);
            this.Delete_HSBAbtn.TabIndex = 2;
            this.Delete_HSBAbtn.Text = "Xóa hồ sơ bệnh án";
            this.Delete_HSBAbtn.UseVisualStyleBackColor = true;
            // 
            // Insert_HSBA_DVbtn
            // 
            this.Insert_HSBA_DVbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insert_HSBA_DVbtn.Location = new System.Drawing.Point(240, 220);
            this.Insert_HSBA_DVbtn.Name = "Insert_HSBA_DVbtn";
            this.Insert_HSBA_DVbtn.Size = new System.Drawing.Size(330, 50);
            this.Insert_HSBA_DVbtn.TabIndex = 3;
            this.Insert_HSBA_DVbtn.Text = "Thêm hồ sơ bệnh án dịch vụ";
            this.Insert_HSBA_DVbtn.UseVisualStyleBackColor = true;
            // 
            // Delete_HSBA_DVbtn
            // 
            this.Delete_HSBA_DVbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_HSBA_DVbtn.Location = new System.Drawing.Point(240, 290);
            this.Delete_HSBA_DVbtn.Name = "Delete_HSBA_DVbtn";
            this.Delete_HSBA_DVbtn.Size = new System.Drawing.Size(330, 50);
            this.Delete_HSBA_DVbtn.TabIndex = 4;
            this.Delete_HSBA_DVbtn.Text = "Xóa hồ sơ bệnh án dịch vụ";
            this.Delete_HSBA_DVbtn.UseVisualStyleBackColor = true;
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
            // MenuCSYT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Returnbtn);
            this.Controls.Add(this.Delete_HSBA_DVbtn);
            this.Controls.Add(this.Insert_HSBA_DVbtn);
            this.Controls.Add(this.Delete_HSBAbtn);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.Insert_HSBAbtn);
            this.Name = "MenuCSYT";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Insert_HSBAbtn;
        private System.Windows.Forms.Label Menu;
        private System.Windows.Forms.Button Delete_HSBAbtn;
        private System.Windows.Forms.Button Insert_HSBA_DVbtn;
        private System.Windows.Forms.Button Delete_HSBA_DVbtn;
        private System.Windows.Forms.Button Returnbtn;
    }
}