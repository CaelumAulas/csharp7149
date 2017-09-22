using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoFuncionario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gerente zeca = new Gerente();
            zeca.Nome = "Zeca";
            zeca.Salario = 5000;
            zeca.Senha = 123;
            zeca.Autentica(456);

            Funcionario ana = new Funcionario();
            ana.Nome = "Ana";
            ana.Salario = 4000;

            Secretario joao = new Secretario();
            joao.Nome = "Joao";
            joao.Salario = 3500;
            joao.Telefone = "3687-8";

            Engenheiro rafael = new Engenheiro();
            rafael.Nome = "Rafael";
            rafael.Salario = 3000;

            ControleDeBonificacao cb = new ControleDeBonificacao();
            cb.Adiciona(zeca);
            cb.Adiciona(ana);
            cb.Adiciona(joao);
            cb.Adiciona(lucas);
            
            MessageBox.Show($"Total de bonificações: {cb.Total}");

            // MessageBox.Show($"Bonicação do {zeca.Nome}: {zeca.Bonificacao()}");
        }
    }
}
