using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatore
{
    public partial class Form1 : Form
    {
        double adadaval, adaddovom, mohasebe;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adadaval = Convert.ToDouble(texAdadAval.Text);
            adaddovom = Convert.ToDouble(texAdadDovom.Text);
            mohasebe = adadaval - adaddovom;
            texMohasebe.Text = mohasebe.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            adadaval = Convert.ToDouble(texAdadAval.Text);
            adaddovom = Convert.ToDouble(texAdadDovom.Text);
            mohasebe = adadaval * adaddovom;
            texMohasebe.Text = mohasebe.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            adadaval = Convert.ToDouble(texAdadAval.Text);
            adaddovom = Convert.ToDouble(texAdadDovom.Text);
            mohasebe = adadaval / adaddovom;
            texMohasebe.Text = mohasebe.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            adadaval = Convert.ToDouble(texAdadAval.Text);
            adaddovom = Convert.ToDouble(texAdadDovom.Text);
            mohasebe = adadaval + adaddovom;
            texMohasebe.Text = mohasebe.ToString();
        }
    }
}
