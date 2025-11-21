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
        public decimal Resultado { get; set; }

        public decimal Valor { get; set; }
        private Operacao OperacaoSelecionada { get; set; }

        private enum Operacao
        {
            mais,
            menos,
            multiplicacao,
            divisao
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void sete_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void oito_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void nove_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void quatro_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void cinco_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void seis_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void um_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void dois_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void zero_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void mais_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.mais;
            Valor = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = "";
            lblOperacao.Text = "+";
        }

        private void menos_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.menos;
            Valor = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = "";
            lblOperacao.Text = "-";
        }

        private void multiplicacao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.multiplicacao;
            Valor = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = ""; 
            lblOperacao.Text = "X";
        }

        private void divisao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.divisao;
            Valor = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = "";
            lblOperacao.Text = "/";
        }

        private void apagar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            lblOperacao.Text = "";
        }

        private void virgula_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(","))
            {
                textBox1.Text += ",";
            }
        }

        private void igual_Click(object sender, EventArgs e)
        {
            switch (OperacaoSelecionada)
            {
                case Operacao.mais:
                    Resultado = Valor + Convert.ToDecimal(textBox1.Text);
                    break;
                case Operacao.menos:
                    Resultado = Valor - Convert.ToDecimal(textBox1.Text);
                    break;
                case Operacao.multiplicacao:
                    Resultado = Valor * Convert.ToDecimal(textBox1.Text);
                    break;
                case Operacao.divisao:
                    Resultado = Valor / Convert.ToDecimal(textBox1.Text);
                    break;
            }
            textBox1.Text = Convert.ToString(Resultado);
            lblOperacao.Text = "=";
        }
    }
}
