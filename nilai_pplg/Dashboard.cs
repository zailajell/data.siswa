using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nilai_pplg
{
    public partial class Dashboard : Form
    {
        public MySqlCommand cmd;
        public MySqlDataReader dr;
        public String id;
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btSiswa_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            panel3.Visible = false;
            Siswa FormAktif = new Siswa();

            FormAktif.MdiParent = this;
            FormAktif.Show();
            FormAktif.Dock = DockStyle.Fill;
            label1.Text = "Data Siswa";
        }

        private void btGuru_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            panel3.Visible = false;
            Guru FormAktif = new Guru();

            FormAktif.MdiParent = this;
            FormAktif.Show();
            FormAktif.Dock = DockStyle.Fill;
            label1.Text = "Data Guru";
        }

        private void btMapel_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            panel3.Visible = false;
            Mapel FormAktif = new Mapel();

            FormAktif.MdiParent = this;
            FormAktif.Show();
            FormAktif.Dock = DockStyle.Fill;
            label1.Text = "Data Mapel";
        }

        private void btNilai_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            panel3.Visible = false;
            Nilai FormAktif = new Nilai();

            FormAktif.MdiParent = this;
            FormAktif.Show();
            FormAktif.Dock = DockStyle.Fill;
            label1.Text = "Data Nilai";
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            panel3.Visible = true;
            label1.Text = "Aplikasi Pendataan Siswa";
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btLogout_Click_1(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
