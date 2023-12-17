
namespace nilai_pplg
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.btSiswa = new System.Windows.Forms.Button();
            this.btGuru = new System.Windows.Forms.Button();
            this.btMapel = new System.Windows.Forms.Button();
            this.btNilai = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btLogout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btSiswa
            // 
            this.btSiswa.BackColor = System.Drawing.Color.Bisque;
            this.btSiswa.Location = new System.Drawing.Point(27, 36);
            this.btSiswa.Name = "btSiswa";
            this.btSiswa.Size = new System.Drawing.Size(99, 35);
            this.btSiswa.TabIndex = 4;
            this.btSiswa.Text = "Siswa";
            this.btSiswa.UseVisualStyleBackColor = false;
            this.btSiswa.Click += new System.EventHandler(this.btSiswa_Click);
            // 
            // btGuru
            // 
            this.btGuru.BackColor = System.Drawing.Color.Bisque;
            this.btGuru.Location = new System.Drawing.Point(27, 87);
            this.btGuru.Name = "btGuru";
            this.btGuru.Size = new System.Drawing.Size(99, 35);
            this.btGuru.TabIndex = 5;
            this.btGuru.Text = "Guru";
            this.btGuru.UseVisualStyleBackColor = false;
            this.btGuru.Click += new System.EventHandler(this.btGuru_Click);
            // 
            // btMapel
            // 
            this.btMapel.BackColor = System.Drawing.Color.Bisque;
            this.btMapel.Location = new System.Drawing.Point(27, 132);
            this.btMapel.Name = "btMapel";
            this.btMapel.Size = new System.Drawing.Size(99, 35);
            this.btMapel.TabIndex = 6;
            this.btMapel.Text = "Mapel";
            this.btMapel.UseVisualStyleBackColor = false;
            this.btMapel.Click += new System.EventHandler(this.btMapel_Click);
            // 
            // btNilai
            // 
            this.btNilai.BackColor = System.Drawing.Color.Bisque;
            this.btNilai.Location = new System.Drawing.Point(27, 179);
            this.btNilai.Name = "btNilai";
            this.btNilai.Size = new System.Drawing.Size(99, 35);
            this.btNilai.TabIndex = 7;
            this.btNilai.Text = "Nilai";
            this.btNilai.UseVisualStyleBackColor = false;
            this.btNilai.Click += new System.EventHandler(this.btNilai_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 94);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(457, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.btLogout);
            this.panel2.Controls.Add(this.btSiswa);
            this.panel2.Controls.Add(this.btGuru);
            this.panel2.Controls.Add(this.btMapel);
            this.panel2.Controls.Add(this.btNilai);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(153, 356);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(153, 94);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(647, 356);
            this.panel3.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(153, 94);
            this.panel4.TabIndex = 0;
            // 
            // btLogout
            // 
            this.btLogout.BackColor = System.Drawing.Color.DodgerBlue;
            this.btLogout.Location = new System.Drawing.Point(27, 273);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(99, 35);
            this.btLogout.TabIndex = 8;
            this.btLogout.Text = "Logout";
            this.btLogout.UseVisualStyleBackColor = false;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click_1);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btSiswa;
        private System.Windows.Forms.Button btGuru;
        private System.Windows.Forms.Button btMapel;
        private System.Windows.Forms.Button btNilai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btLogout;
    }
}