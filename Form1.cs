using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulator
{
    public partial class Form1 : Form

    {
        double w;
        double h;
        double t;

        public Form1()
      
        
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label5.Text = ""; 
            label5.BackColor = Color.White;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.BackColor = Color.White;

            h = Double.Parse(textBox2.Text);
            w = Double.Parse(textBox1.Text);

            t = w / (h * h);

            label5.Text = String.Format("{0:f}", t);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 F2 = new Form2(this);
            this.Visible = false;
            F2.ShowDialog();
            
            
        }
    }
}
