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
        public Form1()
        {
            InitializeComponent();
        }

        private void botaoSaca_Click(object sender, EventArgs e)
        {
            Cliente bruce = new Cliente();
            bruce.Nome = "Bruce";
            bruce.Cpf = "123.765.809-09";

            Conta c1 = new Conta();
            c1.Numero = 123;
            c1.Titular = bruce;
            c1.Deposita(5000);
            
            MessageBox.Show($"Saldo: {c1.Saldo}");
        }
    }
}
