using System;
using System.Windows.Forms;


namespace Grade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_hitung_Click(object sender, EventArgs e)
        {
            double maths, science, indonesian, tot, avg;
            string grade;

            maths = int.Parse(txtmtk.Text);
            science = int.Parse(txtipa.Text);
            indonesian = int.Parse(txtbindo.Text);

            tot = maths + science + indonesian;
            txttotal.Text = tot.ToString();

            avg = tot / 3;
            txtrerata.Text = avg.ToString();

            if (avg >= 95 && avg <= 100)
            {
                grade = "A";
            }
            else if (avg >= 85 && avg < 90)
            {
                grade = "B";
            }
            else if (avg >= 75 && avg < 85) // Perhatikan perbaikan pada kondisi ini
            {
                grade = "C";
            }
            else if (avg >= 65 && avg < 75) // Perhatikan perbaikan pada kondisi ini
            {
                grade = "D";
            }
            else
            {
                grade = "E";
            }

            txtgrade.Text = grade;
        }

        private void btn_keluar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin keluar dari aplikasi?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Aksi yang ingin Anda lakukan jika pengguna menekan tombol "Ya" (Yes)
                Application.Exit(); // Ini akan menutup aplikasi
            }
            // Jika pengguna memilih "Tidak" (No), aplikasi akan tetap berjalan.
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}