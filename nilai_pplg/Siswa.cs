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
    public partial class Siswa : Form
    {
        public MySqlCommand cmd;
        public MySqlDataReader dr;
        public String id;

        public Siswa()
        {
            InitializeComponent();
        }


        private void Tampil()
        {
            try
            {
                Koneksi.conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM `exercise`.`siswa`", Koneksi.conn);

                DataSet ds = new DataSet();

                da.Fill(ds);
                dgsiswa.DataSource = ds.Tables[0];
                Koneksi.conn.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Duh!!, Ada Error Nih");
            }
        }
        private void Clear()
        {
            txtnama.Text = "";
            txtalamat.Text = "";
            txtemail.Text = "";
            txtjurusan.Text = "";
            txtnohp.Text = "";
            txtcari.Text = "";

            btDelete.Enabled = false;
            btUpdate.Enabled = false;
            btCancel.Enabled = false;
            btInsert.Enabled = true;
        }

        private void btInsert_Click(object sender, EventArgs e)
        {

            try
            {
                Koneksi.conn.Open();
                String Queri = "INSERT INTO siswa (`nama`, `jenkel`, `alamat`, `nohp`, `jurusan`, `email`) VALUES ('" + txtnama.Text + "', '" + cbjenkel.Text + "', '" + txtalamat.Text + "', '" + txtnohp.Text + "', '" + txtjurusan.Text + "', '" + txtemail.Text + "')";
                cmd = new MySqlCommand(Queri, Koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Simpan Data Siswa");
                Koneksi.conn.Close();

                Tampil(); 
                Clear(); 
            }
            catch (Exception)
            {

                MessageBox.Show("Tambah Data Gagal");
            }
        }

        private void Siswa_Load(object sender, EventArgs e)
        {
            Tampil();
            btDelete.Enabled = false;
            btUpdate.Enabled = false;
            btCancel.Enabled = false;
        }

        private void dgsiswa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btDelete.Enabled = true;
            btUpdate.Enabled = true;
            btCancel.Enabled = true;
            btInsert.Enabled = false;

            int baris = dgsiswa.CurrentCell.RowIndex;
            id = dgsiswa.Rows[baris].Cells[0].Value.ToString();
            txtnama.Text = dgsiswa.Rows[baris].Cells[1].Value.ToString();
            cbjenkel.Text = dgsiswa.Rows[baris].Cells[2].Value.ToString();
            txtalamat.Text = dgsiswa.Rows[baris].Cells[3].Value.ToString();
            txtnohp.Text = dgsiswa.Rows[baris].Cells[4].Value.ToString();
            txtjurusan.Text = dgsiswa.Rows[baris].Cells[5].Value.ToString();
            txtemail.Text = dgsiswa.Rows[baris].Cells[6].Value.ToString();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi.conn.Open();
                String Queri = "UPDATE siswa SET `nama`='" + txtnama.Text + "', `jenkel`='" + cbjenkel.Text + "', `alamat`='" + txtalamat.Text + "', `nohp`='" + txtnohp.Text + "', `jurusan`='" + txtjurusan.Text + "', `email`='" + txtemail.Text + "' WHERE  `id`='" + id + "'";
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

                cmd = new MySqlCommand("DELETE FROM siswa WHERE  `id`= '" + id + "'", Koneksi.conn);
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

        private void btCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void txtcari_TextChanged(object sender, EventArgs e)
        {
            try
            {

                Koneksi.conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM `siswa` where nama LIKE '%" + txtcari.Text + "%'", Koneksi.conn);
                DataSet ds = new DataSet();

                da.Fill(ds);
                dgsiswa.DataSource = ds.Tables[0];
                Koneksi.conn.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Duh!!, Ada Error Nih");
            }
        }
    }
}
