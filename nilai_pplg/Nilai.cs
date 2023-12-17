﻿using MySql.Data.MySqlClient;
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
    public partial class Nilai : Form
    {
        public MySqlCommand cmd;
        public MySqlDataReader dr;
        public String id;
        public Nilai()
        {
            InitializeComponent();
        }

        private void Clear()
        {
            cbmapel.Text = "";
            cbpilihsiswa.Text = "";
            txtnilai.Text = "";

            txtcari.Text = "";

            btDelete.Enabled = false;
            btUpdate.Enabled = false;
            btClear.Enabled = false;
            btInsert.Enabled = true;
        }
        private void Tampil()
        {
            try
            {

                Koneksi.conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM `vnilai`", Koneksi.conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgnilai.DataSource = ds.Tables[0];
                Koneksi.conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Duh!!, Ada Error Nih");
            }
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi.conn.Open();
                String Queri = "INSERT INTO nilai (`siswa_id`, `mapel_id`, `nilai`) VALUES ('" + cbpilihsiswa.SelectedValue + "','" + cbmapel.SelectedValue + "', '" + txtnilai.Text + "')";
                cmd = new MySqlCommand(Queri, Koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Simpan Nilai Siswa");
                Koneksi.conn.Close();

                Tampil();
                Clear();
            }
            catch (Exception)
            {

                MessageBox.Show("Tambah Data Gagal");
            }
        }

       
        private void Nilai_Load(object sender, EventArgs e)
        {
            Tampil();

            MySqlDataAdapter adp = new MySqlDataAdapter("select * from mapel", Koneksi.conn);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            cbmapel.DataSource = dt;
            cbmapel.DisplayMember = "nama_mapel";
            cbmapel.ValueMember = "id";

            MySqlDataAdapter adp2 = new MySqlDataAdapter("select * from siswa", Koneksi.conn);
            DataTable dt2 = new DataTable();
            adp2.Fill(dt2);

            cbpilihsiswa.DataSource = dt2;
            cbpilihsiswa.DisplayMember = "nama";
            cbpilihsiswa.ValueMember = "id";

            btDelete.Enabled = false;
            btUpdate.Enabled = false;
            btClear.Enabled = false;

        }

        private void dgnilai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btDelete.Enabled = true;
            btUpdate.Enabled = true;
            btClear.Enabled = true;
            btInsert.Enabled = false;

            int baris = dgnilai.CurrentCell.RowIndex;
            id = dgnilai.Rows[baris].Cells[0].Value.ToString();
            cbpilihsiswa.Text = dgnilai.Rows[baris].Cells[1].Value.ToString();
            cbmapel.Text = dgnilai.Rows[baris].Cells[3].Value.ToString();
            txtnilai.Text = dgnilai.Rows[baris].Cells[5].Value.ToString();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi.conn.Open();

                String Queri = "UPDATE `nilai` SET `siswa_id`='" + cbpilihsiswa.SelectedValue + "', `mapel_id`='" + cbmapel.SelectedValue + "', `nilai`='" + txtnilai.Text + "' WHERE  `id`='" + id + "'";
                cmd = new MySqlCommand(Queri, Koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Update Data Siswa");
                Koneksi.conn.Close();

                Tampil();
                Clear();
            }
            catch (Exception)
            {

                MessageBox.Show("Update Gagal");
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi.conn.Open();


                cmd = new MySqlCommand("DELETE FROM nilai WHERE  `id`= '" + id + "'", Koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Hapus Data Siswa");
                Koneksi.conn.Close();

                Tampil();
                Clear();
            }
            catch (Exception)
            {

                MessageBox.Show("Hapus Data Gagal");
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            try
            {

                Koneksi.conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM `vnilai` where nama LIKE '%" + txtcari.Text + "%'", Koneksi.conn);
                DataSet ds = new DataSet();

                da.Fill(ds);
                dgnilai.DataSource = ds.Tables[0];
                Koneksi.conn.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Duh!!, Ada Error Nih");
            }
        }

        private void txtcari_TextChanged(object sender, EventArgs e)
        {
            try
            {

                Koneksi.conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM `vnilai` where nama LIKE '%" + txtcari.Text + "%'", Koneksi.conn);
                DataSet ds = new DataSet();

                da.Fill(ds);
                dgnilai.DataSource = ds.Tables[0];
                Koneksi.conn.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Duh!!, Ada Error Nih");
            }
        }
    }
}
