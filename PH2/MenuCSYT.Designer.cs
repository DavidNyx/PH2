
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
            this.Insert_HSBA_DVbtn = new System.Windows.Forms.Button();
            this.Returnbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Insert_HSBAbtn
            // 
            this.Insert_HSBAbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insert_HSBAbtn.Location = new System.Drawing.Point(240, 139);
            this.Insert_HSBAbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Insert_HSBAbtn.Name = "Insert_HSBAbtn";
            this.Insert_HSBAbtn.Size = new System.Drawing.Size(331, 50);
            this.Insert_HSBAbtn.TabIndex = 0;
            this.Insert_HSBAbtn.Text = "Thêm/Xóa hồ sơ bệnh án";
            this.Insert_HSBAbtn.UseVisualStyleBackColor = true;
            this.Insert_HSBAbtn.Click += new System.EventHandler(this.Insert_HSBAbtn_Click);
            // 
            // Menu
            // 
            this.Menu.AutoSize = true;
            this.Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu.Location = new System.Drawing.Point(349, 9);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(119, 46);
            this.Menu.TabIndex = 1;
            this.Menu.Text = "Menu";
            // 
            // Insert_HSBA_DVbtn
            // 
            this.Insert_HSBA_DVbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Insert_HSBA_DVbtn.Location = new System.Drawing.Point(240, 213);
            this.Insert_HSBA_DVbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Insert_HSBA_DVbtn.Name = "Insert_HSBA_DVbtn";
            this.Insert_HSBA_DVbtn.Size = new System.Drawing.Size(331, 50);
            this.Insert_HSBA_DVbtn.TabIndex = 3;
            this.Insert_HSBA_DVbtn.Text = "Thêm/Xóa hồ sơ bệnh án dịch vụ";
            this.Insert_HSBA_DVbtn.UseVisualStyleBackColor = true;
            // 
            // Returnbtn
            // 
            this.Returnbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Returnbtn.Location = new System.Drawing.Point(240, 287);
            this.Returnbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Returnbtn.Name = "Returnbtn";
            this.Returnbtn.Size = new System.Drawing.Size(331, 50);
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
            this.Controls.Add(this.Insert_HSBA_DVbtn);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.Insert_HSBAbtn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MenuCSYT";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Insert_HSBAbtn;
        private System.Windows.Forms.Label Menu;
        private System.Windows.Forms.Button Insert_HSBA_DVbtn;
        private System.Windows.Forms.Button Returnbtn;
    }
}