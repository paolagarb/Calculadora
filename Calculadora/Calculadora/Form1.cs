using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        private double num1, num2;
        private string operacao = "";
        private bool resultado;

        public Form1()
        {
            InitializeComponent();
        }

        private void Calcular()
        {
            switch (operacao)
            {

                case "+":
                    txtResultado.Text = (num1 + num2).ToString();
                    break;
                case "-":
                    txtResultado.Text = (num1 - num2).ToString();
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        MessageBox.Show("Erro! Não é possível realizar divisão por 0.");
                        break;
                    }
                    else
                    {
                        txtResultado.Text = (num1 / num2).ToString();
                        break;
                    }

                case "*":
                    txtResultado.Text = (num1 * num2).ToString();
                    break;
                    /* case "√":
                         txtResultado.Text = (Math.Sqrt(num2)).ToString();
                         break;*/
            }
        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultado)
            {
                txtResultado.Clear();
                resultado = false;
            }
            txtResultado.Text += button.Text;

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
            num1 = 0;
            num2 = 0;
            resultado = false;
            operacao = string.Empty;
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            if (!(txtResultado.Text.Equals(string.Empty)))
            {
                num1 = Convert.ToDouble(txtResultado.Text);
                operacao = "+";
                txtResultado.Clear();
            }
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            if (!(txtResultado.Text.Equals(string.Empty)))
            {
                num1 = Convert.ToDouble(txtResultado.Text);
                operacao = "-";
                txtResultado.Clear();
            }
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            if (!(txtResultado.Text.Equals(string.Empty)))
            {
                num1 = Convert.ToDouble(txtResultado.Text);
                operacao = "*";
                txtResultado.Clear();
            }
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            if (!(txtResultado.Text.Equals(string.Empty)))
            {
                num1 = Convert.ToDouble(txtResultado.Text);
                operacao = "/";
                txtResultado.Clear();
            }
        }


        private void btnRaiz_Click(object sender, EventArgs e)
        {
            if (!(txtResultado.Text.Equals(string.Empty)))
            {
                num1 = Convert.ToDouble(txtResultado.Text);
                txtResultado.Text = (Math.Sqrt(num1)).ToString();
                resultado = false;
            }
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text.Equals(string.Empty))
            {
                txtResultado.Text = "0,";
            }
            else
            {
                txtResultado.Text += ",";
            }
            resultado = false;
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            if (!(txtResultado.Text.Equals(string.Empty)))
            {
                num2 = Convert.ToDouble(txtResultado.Text);
                Calcular();
                resultado = true;
            }
        }
    }
}
