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

        string oprand = "";
        double adadaval, adaddovom, mohasebe;
        string operation = "";
        double value = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void texAdadDovom_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            texAdadAval.Clear();
            //texAdadDovom.Clear();
        }
        private void clear()
        {
            texAdadAval.Clear();
            //texAdadDovom.Clear();
        }

        private void texMohasebe_TextChanged(object sender, EventArgs e)
        {

        }

        //private void showbtn_Click(object sender, EventArgs e)
        //{
        //    //texrez.AppendText(texAdadAval + "   " + "amaliat morede nazar" + texAdadDovom + "    =    " + texMohasebe);
        //    //richrez
        //    string sent = texAdadAval.Text + oprand + texAdadDovom.Text + " = " + texMohasebe.Text;

        //    richrez.AppendText(sent);
        //    richrez.AppendText(Environment.NewLine);
        //}
        //private void show()
        //{
        //    //texrez.AppendText(texAdadAval + "   " + "amaliat morede nazar" + texAdadDovom + "    =    " + texMohasebe);
        //    //richrez
        //    string sent = texAdadAval.Text + oprand + texAdadDovom.Text + " = " + texMohasebe.Text;

        //    richrez.AppendText(sent);
        //    richrez.AppendText(Environment.NewLine);
        //}

        private void texrez_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(texAdadAval.Text.Length > 0)
            {
                texAdadAval.Text = texAdadAval.Text.Remove(texAdadAval.Text.Length - 1, 1);
            }
        }

        private void btnNum(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            texAdadAval.Text = texAdadAval.Text + button.Text;
            
        }

        private void operationclick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            value = double.Parse(texAdadAval.Text);
            clear();
        }

        private void btnRezclick(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    richrez.AppendText(value.ToString() + operation + texAdadAval.Text + " = " + (value + double.Parse(texAdadAval.Text)).ToString()+"\n");
                    
                    break;
                case "-":
                    richrez.AppendText(value.ToString() + operation + texAdadAval.Text + " = " + (value - double.Parse(texAdadAval.Text)).ToString() + "\n");

                    break;
                case "*":
                    richrez.AppendText(value.ToString() + operation + texAdadAval.Text + " = " + (value * double.Parse(texAdadAval.Text)).ToString() + "\n");

                    break;
                case "/":
                    richrez.AppendText(value.ToString() + operation + texAdadAval.Text + " = " + (value / double.Parse(texAdadAval.Text)).ToString() + "\n");

                    break;
                default:
                    break;
            }

            clear();
        }

        private void richrez_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    adadaval = Convert.ToDouble(texAdadAval.Text);
        //    adaddovom = Convert.ToDouble(texAdadDovom.Text);
        //    mohasebe = adadaval + adaddovom;
        //    texMohasebe.Text = mohasebe.ToString();
        //    oprand = " + ";
        //    show();
        //    clear();
        //}
    }
}
