using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica2_Kalkuladora
{
    public partial class FormMain : Form
    {
        int num1 = 0;
        int num2 = 0;
        //int total = 0;
        string opcion;
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Aquesta calculadora només treballa amb números enters","INFORMACIÓ",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            if(int.Parse(tbNumero.Text)==0) //|| tbNumero.Text == ""
            {
                tbNumero.Text = ((Button)sender).Tag.ToString();
            }
            else
            {
                tbNumero.Text = tbNumero.Text + ((Button)sender).Tag.ToString();
            }
        }

        private void btClean_Click(object sender, EventArgs e)
        {
            tbNumero.Text = bt0.Tag.ToString();
        }

        private void btSumar_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(tbNumero.Text);
            tbNumero.Text = bt0.Tag.ToString();
            //tbNumero.Text ="";
            opcion = "+";
        }

        private void btRestar_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(tbNumero.Text);
            tbNumero.Text = bt0.Tag.ToString();
            //tbNumero.Text = "";
            opcion = "-";
        }

        private void btDividir_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(tbNumero.Text);
            tbNumero.Text = bt0.Tag.ToString();
            //tbNumero.Text = "";
            opcion = "/";
        }

        private void btMultiplicar_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(tbNumero.Text);
            tbNumero.Text = bt0.Tag.ToString();
            //tbNumero.Text = "";
            opcion = "*";
        }

        private void btIgual_Click(object sender, EventArgs e)
        {
            if(tbNumero.Text=="")
            {
                MessageBox.Show("Falta numero", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                num2 = int.Parse(tbNumero.Text);
                switch (opcion)
                {
                    case "+":
                        tbNumero.Text = Convert.ToString(num1 + num2);
                        break;

                    case "-":
                        tbNumero.Text = Convert.ToString(num1 - num2);
                        break;

                    case "*":
                        tbNumero.Text = Convert.ToString(num1 * num2);
                        break;

                    case "/":
                        if (num2 == 0)
                        {
                            tbNumero.Text = "ERROR";
                        }
                        else
                        {
                            tbNumero.Text = Convert.ToString(num1 / num2);
                        }
                        break;
                }
            }  
        }
    }
}
