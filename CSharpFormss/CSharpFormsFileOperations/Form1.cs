using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Linq.Expressions;

namespace CSharpFormsFileOperations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            try
            {
                string path = "C:\\ProgramFiles\\deneme.txt"; // Dosya yolu düzeltildi
                StreamWriter dosya = new StreamWriter(path);
                dosya.WriteLine(txtYazdir.Text);
                dosya.Close();
                MessageBox.Show("İşlem başarılı");
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem başarısız \n" + hata.Message);
            }
        }

        private void btnOku_Click(object sender, EventArgs e)
        {
            try
            {
                string path = "C:\\ProgramFiles\\deneme.txt"; // Dosya yolu düzeltildi
                StreamReader dosya = new StreamReader(path);
                txtOku.Text = dosya.ReadToEnd();
                dosya.Close();
                MessageBox.Show("İşlem başarılı");
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem başarısız \n" + hata.Message);
            }
        }
    }
}

