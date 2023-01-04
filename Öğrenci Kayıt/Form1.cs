using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Öğrenci_Kayıt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sira_no = listBox1.SelectedIndex;
            listBox1.SelectedIndex = sira_no;
            listBox2.SelectedIndex = sira_no;
            listBox3.SelectedIndex = sira_no;
            listBox4.SelectedIndex = sira_no;
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sira_no = listBox2.SelectedIndex;
            listBox1.SelectedIndex = sira_no;
            listBox2.SelectedIndex = sira_no;
            listBox3.SelectedIndex = sira_no;
            listBox4.SelectedIndex = sira_no;
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sira_no = listBox3.SelectedIndex;
            listBox1.SelectedIndex = sira_no;
            listBox2.SelectedIndex = sira_no;
            listBox3.SelectedIndex = sira_no;
            listBox4.SelectedIndex = sira_no;
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sira_no = listBox4.SelectedIndex;
            listBox1.SelectedIndex = sira_no;
            listBox2.SelectedIndex = sira_no;
            listBox3.SelectedIndex = sira_no;
            listBox4.SelectedIndex = sira_no;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("Enter your name!", "Warning!", MessageBoxButtons.OK);
            else if (textBox3.Text == "")
                MessageBox.Show("Enter your student no!", "Warning!", MessageBoxButtons.OK);
            else if (comboBox1.SelectedItem == null)
                MessageBox.Show("Choose your gender!", "Warning!", MessageBoxButtons.OK);
            else if (comboBox2.SelectedItem == null) 
                MessageBox.Show("Choose  your department", "Warning!", MessageBoxButtons.OK);
            else
            {
                listBox1.Items.Add(textBox1.Text);
                listBox2.Items.Add(textBox3.Text);
                listBox3.Items.Add(comboBox1.Text);
                listBox4.Items.Add(comboBox2.Text);
            }

                    
                   
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int sira_no = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(sira_no);
            listBox2.Items.RemoveAt(sira_no);
            listBox3.Items.RemoveAt(sira_no);
            listBox4.Items.RemoveAt(sira_no);

        }
    }
}
