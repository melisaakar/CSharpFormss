using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpFormsListBoxOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Melisa");

        }



        private void btnEkle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text.ToString());

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblIndex.Text = listBox1.SelectedIndex.ToString();  
            lblIsim.Text = listBox1.SelectedItem.ToString();
        }
    }
}
