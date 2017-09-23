using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] idades = new int[10];
            idades[0] = 45;
            idades[1] = 26;
            idades[2] = 60;
            idades[3] = 28;
            idades[4] = 29;
            idades[5] = 53;
            idades[6] = 24;
            idades[7] = 19;
            idades[8] = 23;
            idades[9] = 35;

            int soma = 0;

            for (int i = 0; i < idades.Length; i++)
            {
                soma = soma + idades[i];
            }

            double media = soma / idades.Length;

            MessageBox.Show("Média: " + media);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conta contaAna = new Conta();
            contaAna.Titular = "Ana";
            contaAna.Deposita(500);
            contaAna.Numero = 123;

            Conta[] contas = new Conta[3];
            contas[0] = contaAna;
            contas[1] = new Conta();
            contas[1].Titular = "Rafael";
            contas[1].Deposita(1500);
            contas[2] = new Conta();
            contas[2].Titular = "Jeferson";
            contas[2].Deposita(2000);


            /*for(int i = 0; i < contas.Length; i++)
            {
                MessageBox.Show(contas[i].Titular);
            }*/

            foreach (var conta in contas)
            {
                MessageBox.Show(conta.Titular);
            }
        }
    }
}
