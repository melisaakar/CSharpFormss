using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpFormsCheckedListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Insert(3, "DENİZLİ");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (string item in checkedListBox1.CheckedItems)
            {
               listBox1.Items.Add(item);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text="Toplam eleman sayısı="+checkedListBox1.Items.Count.ToString();
            bool aranilan=checkedListBox1.Items.Contains("ERZURUM");
            if(aranilan==true)
            {               
                label3.Text = "ERZURUM bulundu";
            }
            else
            {
                label3.Text = "ERZURUM bulunamadı";
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender ,EventArgs e)

        {
            label2.Text = "";
            label2.Text="Seçili eleman sayısı=" + checkedListBox1.SelectedItems.Count.ToString();   

        }

        
    }
}
