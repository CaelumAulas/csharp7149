using System;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form1 : Form
    {
        private Conta[] contas;
        private int numeroDeContas;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            contas = new Conta[10];

            Cliente victor = new Cliente("Victor");
            Conta conta0 = new Conta();
            conta0.Titular = victor;
            conta0.Numero = 123;
            AdicionaConta(conta0);

            Cliente ana = new Cliente("Ana");
            Conta conta1 = new Conta();
            conta1.Titular = ana;
            conta1.Numero = 345;
            AdicionaConta(conta1);

            Cliente osni = new Cliente("Osni");
            Conta conta2 = new Conta();
            conta2.Titular = osni;
            conta2.Numero = 890;
            AdicionaConta(conta2);
        }

        public void AdicionaConta(Conta novaConta)
        {
            contas[numeroDeContas] = novaConta;
            numeroDeContas++;
            comboContas.Items.Add("titular: " + novaConta.Titular.Nome);
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

        private void botaoCadastro_Click(object sender, EventArgs e)
        {
            FormCadastro formCadastro = new FormCadastro(this);
            formCadastro.ShowDialog();
        }
    }
}
