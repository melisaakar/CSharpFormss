using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpFormsListBoxKuraCekme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            int l_sayi= listBox1.Items.Count;
            int[] isimler = new int[l_sayi];
            Random rnd=new Random();
            int i = 0;
            while(i<3)
            {
                int secim = rnd.Next(0, l_sayi);
                if (Array.IndexOf(isimler,secim)==-1)
                {
                    isimler[i] = secim;
                    label1.Text += listBox1.Items[secim-1] + "\n";
                    i++;


                }

            }


        }
    }
}
