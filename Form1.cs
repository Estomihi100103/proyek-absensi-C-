using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_Absensi_Kelompok_1
{
    public partial class FormArray : Form
    {
        private string[,] Arr = new string[4, 8];

        public FormArray()
        {
            InitializeComponent();

            // Mengisi array 2D dengan data
            Arr[0, 0] = "NIM";
            Arr[0, 1] = "Nama";
            Arr[1, 0] = "Jenis Kelamin";
            Arr[1, 1] = "Program Studi";
            Arr[2, 0] = "Laki-Laki";
            Arr[2, 1] = "Perempuan";
            Arr[3, 0] = "Manajemen Rekayasa";
            Arr[3, 1] = "Teknik Metalurgi";
            Arr[3, 2] = "Sistem Informasi";
            Arr[3, 3] = "Informatika";
            Arr[3, 4] = "Teknik Elektro";
            Arr[3, 5] = "Teknologi Rekayasa Perangkat Lunak";
            Arr[3, 6] = "Teknologi Informasi";
            Arr[3, 7] = "Teknologi Komputer";
            Arr[3, 8] = "Teknik Bioproses";

            // Konfigurasi ListView
            lstKonfirmasi.GridLines = true;
            lstKonfirmasi.View = View.Details;

            for (int baris = 0; baris <= 1; baris++)
            {
                for (int kolom = 0; kolom <= 1; kolom++)
                {
                    lstKonfirmasi.Columns.Add(Arr[kolom, 0], 120);
                    lstKonfirmasi.Columns.Add(Arr[kolom, 1], 120);
                }
            }

            for (int kolom = 2; kolom <= 3; kolom++)
            {
                cbJenisKelamin.Items.Add(Arr[kolom, 0]);
            }

            for (int kolom = 3; kolom < Arr.GetLength(1); kolom++)
            {
                if (!string.IsNullOrEmpty(Arr[3, kolom]) || !string.IsNullOrEmpty(Arr[4, kolom]))
                {
                    cbProgramStudi.Items.Add(Arr[3, kolom]);
                    cbProgramStudi.Items.Add(Arr[4, kolom]);
                }
            }
        }
        private void btnKonfirmasi_Click(object sender, EventArgs e)
        {
            string[] dataArr = new string[4];
            dataArr[0] = txtNIM.Text;
            dataArr[1] = txtNama.Text;
            dataArr[2] = cbJenisKelamin.Text;
            dataArr[3] = cbProgramStudi.Text;

            ListViewItem listItem = new ListViewItem(dataArr[0]);
            listItem.SubItems.Add(dataArr[1]);
            listItem.SubItems.Add(dataArr[2]);
            listItem.SubItems.Add(dataArr[3]);
            lstKonfirmasi.Items.Add(listItem);

            // Membersihkan input setelah data dimasukkan
            txtNIM.Text = (int.Parse(txtNIM.Text) + 1).ToString();
            txtNama.Clear();
            cbJenisKelamin.SelectedIndex = -1;
            cbProgramStudi.SelectedIndex = -1;
            txtNama.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}