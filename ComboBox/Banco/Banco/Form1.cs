using System;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form1 : Form
    {
        private Conta[] contas;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            contas = new Conta[3];

            Cliente victor = new Cliente("Victor");
            contas[0] = new Conta();
            contas[0].Titular = victor;
            contas[0].Numero = 123;

            Cliente ana = new Cliente("Ana");
            contas[1] = new Conta();
            contas[1].Titular = ana;
            contas[1].Numero = 345;

            Cliente osni = new Cliente("Osni");
            contas[2] = new Conta();
            contas[2].Titular = osni;
            contas[2].Numero = 890;

            foreach (var conta in contas)
            {
                comboContas.Items.Add("titular: " + conta.Titular.Nome);
            }
        }

        private void botaoDeposita_Click(object sender, EventArgs e)
        {
            
            int indice = comboContas.SelectedIndex;
            Conta selecionada = contas[indice];

            string valorDigitado = textoValor.Text;
            var valor = Convert.ToDouble(valorDigitado);
            selecionada.Deposita(valor);

            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
            MessageBox.Show("Sucesso!");
        }

        private void botaoSaque_Click(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = contas[indice];

            string valorDigitado = textoValor.Text;
            double valor = Convert.ToDouble(valorDigitado);
            selecionada.Saca(valor);

            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
            MessageBox.Show("Sucesso");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = this.contas[indice];

            textoTitular.Text = selecionada.Titular.Nome;
            textoNumero.Text = Convert.ToString(selecionada.Numero);
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
        }
    }
}
