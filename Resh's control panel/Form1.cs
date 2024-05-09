using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resh_s_control_panel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;

            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;

            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;

            button3.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderSize = 0;

            button6.FlatStyle = FlatStyle.Flat;
            button6.FlatAppearance.BorderSize = 0;

            button7.FlatStyle = FlatStyle.Flat;
            button7.FlatAppearance.BorderSize = 0;

            button5.FlatStyle = FlatStyle.Flat;
            button5.FlatAppearance.BorderSize = 0;

            button4.FlatStyle = FlatStyle.Flat;
            button4.FlatAppearance.BorderSize = 0;

            this.label2.Text = "0\n1\n1\n0\n1\n0\n1\n0\n0\n1\n1\n1\n0\n1\n0\n0\n1\n0\n1\n0\n1\n1\n0\n1\n1\n0\n0\n1\n1\n0\n0\n1\n1\n0\n1\n0\n0\n1\n1\n1\n0\n1\n0\n1\n0\n1\n1\n0\n1\n0\n1\n1\n0\n0\n1\n0";
            this.label3.Text = "1\n0\n1\n0\n1\n1\n1\n0\n1\n0\n0\n1\n1\n1\n1\n0\n1\n0\n1\n0\n1\n1\n0\n1\n1\n0\n0\n1\n0\n0\n0\n1\n0\n1\n0\n0\n1\n1\n0\n1\n1\n1\n0\n1\n0\n1\n0\n0\n1\n1\n0\n0\n1\n0\n0\n1";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Users\\RESHAN\\Pictures\\New folder");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("D:\\Downloads\\anime");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Users\\RESHAN\\Pictures\\Screenshots");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Users\\RESHAN\\music");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("D:\\");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
