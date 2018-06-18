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
    public partial class Form2 : Form
    {
        double s;
        double j;
        double z;
        double c;
        double a;
        double p;
        double b;
        double r;
        double o;
        double m;
        double n;
        double k;
        double v;
        double q;
        double d;
        double y;
        double i;
        double u;
        double f;
        double g;
        double t;

        Form1 OG;


        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Form1 OB)
        {
            InitializeComponent();
            OG=OB;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            OG.Visible = true;
        }

        private void policzstr_Click(object sender, EventArgs e)
        {
            wynikstr.BackColor = Color.White;

            s = Double.Parse(txtstr.Text);
            j = Double.Parse(txtwaga.Text);

            z = j * s*0.05;
            o = s * 5;
         

            wynikstr.Text = String.Format("{0:f}", z);
            wynikstrw.Text = String.Format("{0:f}", o);
        }

        private void policzchod_Click(object sender, EventArgs e)
        {
            wynikchod.BackColor = Color.White;

            c = Double.Parse(txtchod.Text);
            j = Double.Parse(txtwaga.Text);

            n = j * c * 0.05;

            t = c * 4;

            wynikchod.Text = String.Format("{0:f}", n);
            wynikchodw.Text = String.Format("{0:f}", t);
        }

        private void policzaero_Click(object sender, EventArgs e)
        {
            wynikaero.BackColor = Color.White;

            a = Double.Parse(txtaero.Text);
            j = Double.Parse(txtwaga.Text);

            k = j * a * 0.068;

            f = a * 33.3;

            wynikaero.Text = String.Format("{0:f}", k);
            wynikaerow.Text = String.Format("{0:f}", f);
        }

        private void policzplywanie_Click(object sender, EventArgs e)
        {
            wynikplywanie.BackColor = Color.White;

            p = Double.Parse(txtplywanie.Text);
            j = Double.Parse(txtwaga.Text);

            q = p * j * 0.074;

            u = p * 5.3;

            wynikplywanie.Text = String.Format("{0:f}", q);
            wynikplywaniew.Text = String.Format("{0:f}", u);
        }

        private void policzbieganie_Click(object sender, EventArgs e)
        {
            wynikbieganie.BackColor = Color.White;

            b = Double.Parse(txtbieganie.Text);
            j = Double.Parse(txtwaga.Text);

            d = j * b * 0.111;

            i = b * 10;

            wynikbieganie.Text = String.Format("{0:f}", d);
            wynikbieganiew.Text = String.Format("{0:f}", i);
        }

        private void policzrower_Click(object sender, EventArgs e)
        {
            wynikrower.BackColor = Color.White;

            r = Double.Parse(txtrower.Text);
            j = Double.Parse(txtwaga.Text);

            v = j * r * 0.086;

            y = r * 8.3;

            wynikrower.Text = String.Format("{0:f}", v);
            wynikrowerw.Text = String.Format("{0:f}", y);
        }

        private void bsuma_Click(object sender, EventArgs e)
        {
            m = z+n+k+q+d+v;
            
            suma.Text = String.Format("{0:f}", m);
        }

        private void bsumaw_Click(object sender, EventArgs e)
        {
            g = o + t + f + u + i + y;

            sumaw.Text = String.Format("{0:f}", g);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
