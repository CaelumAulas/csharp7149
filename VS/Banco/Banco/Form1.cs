using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form1 : Form
    {
        private Conta c;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            c = new Conta();
            c.Numero = 123;

            Cliente ana = new Cliente("Ana");
            c.Titular = ana;

            textoTitular.Text = c.Titular.Nome;
            textoNumero.Text = Convert.ToString(c.Numero);
            textoSaldo.Text = Convert.ToString(c.Saldo);
        }

        private void botaoDeposita_Click(object sender, EventArgs e)
        {
            string valorDigitado = textoValor.Text;
            var valor = Convert.ToDouble(valorDigitado);
            c.Deposita(valor);
            textoSaldo.Text = Convert.ToString(c.Saldo);
            MessageBox.Show("Sucesso!");
        }

        private void botaoSaque_Click(object sender, EventArgs e)
        {
            string valorDigitado = textoValor.Text;
            double valor = Convert.ToDouble(valorDigitado);
            c.Saca(valor);
            textoSaldo.Text = Convert.ToString(c.Saldo);
            MessageBox.Show("Sucesso");
        }
    }
}
