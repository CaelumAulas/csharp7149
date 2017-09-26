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
            
            Secretario joao = new Secretario();
            joao.Nome = "Joao";
            joao.Salario = 3500;
            joao.Telefone = "3687-8";

            Diretor jeferson = new Diretor();
            jeferson.Nome = "Jeferson";
            jeferson.Salario = 5000;
            jeferson.Senha = 897;

            Cliente jose = new Cliente();
            jose.Nome = "Jose";
            jose.Senha = 123;
            jose.Autentica(789);
            
            SistemaInterno si = new SistemaInterno();
            si.Login(zeca);
            si.Login(jeferson);
        }
    }
}
