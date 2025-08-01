using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpFormsCreatingAnOvalButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("Müşteri No", 50);
            listView1.Columns.Add("Adı Soyadı", 100);
            listView1.Columns.Add("Telefon", 60);
            listView1.Columns.Add("Adres", 100);
            ListViewItem item = new ListViewItem();
            item.SubItems.Add("Melisa AKAR");
            item.SubItems.Add("545");
            item.SubItems.Add("ANKARA");
            listView1.Items.Add(item);

        }
    }
}

