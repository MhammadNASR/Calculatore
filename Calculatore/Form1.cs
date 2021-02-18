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

        private void texAdadDovom_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            //Action<Control.ControlCollection> func = null;
            //func = (controls) =>
            //{
            //    foreach (Control control in controls)
            //    {
            //        if ( control is TextBox)
            //        {
            //            (control as TextBox).Clear();
            //        }
            //        else
            //        {
            //            func(control.Controls);
            //        }
            //    }
            //};
            //func(Controls);
            texAdadAval.Clear();
            texAdadDovom.Clear();
        }

        private void texMohasebe_TextChanged(object sender, EventArgs e)
        {

        }

        private void showbtn_Click(object sender, EventArgs e)
        {
            texrez.AppendText(texAdadAval + "   " + "amaliat morede nazar" + texAdadDovom + "    =    " + texMohasebe);
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
