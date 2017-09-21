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
            Cliente bruce = new Cliente("Bruce")
            {
                Cpf = "123.765.809-09"
            };
            

            Cliente ana = new Cliente()
            {
                Nome = "Ana",
                Cpf = "8094"
            };


            Cliente zeca = new Cliente("Zeca", "809.809.789-35");

            Conta c1 = new Conta();
            c1.Numero = 123;
            c1.Titular = bruce;
            c1.Deposita(5000);
            
            MessageBox.Show($"Nome: {bruce.Nome}");
        }
    }
}
