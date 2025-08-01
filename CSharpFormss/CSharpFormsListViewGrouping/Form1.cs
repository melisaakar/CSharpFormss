using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpFormsListViewGrouping
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true)
            {
                listView1.ShowGroups = true;
            }
            else
            {
                listView1.ShowGroups = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int resimindex;

            if(comboBox1.SelectedIndex == 0)
            {
                resimindex = 0;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                resimindex = 1;
            }
         
            
            ListViewItem item = new ListViewItem(textBox1.Text, resimindex);

            if (resimindex == 0)
            {
                item.Group = listView1.Groups["Bay"];
                
            }
            else
            {
                item.Group = listView1.Groups["Bayan"];
            }

                item.SubItems.Add(textBox2.Text);
            item.SubItems.Add(textBox3.Text);
            item.SubItems.Add(textBox4.Text);
            listView1.Items.Add(item);



        }

       
        
    }
}
