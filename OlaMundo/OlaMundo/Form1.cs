using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlaMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // variavel que guarada o valor do nome
            string nome = "Thiago";
            /*
             * variavel que guarda a idade
             */
            int idade = 16;
            double altura = 1.8;
            float peso = 95.5f;
            bool ehFumante = true;
            char sexo = 'M';

            decimal preco = 79.9m;

            bool amigoDoDono = true;
            if (idade >= 18 || amigoDoDono)
            {
                MessageBox.Show("Pode se matricular");
            }
            else
            {
                MessageBox.Show("Não pode ainda!");
            }

            for(int i = 0; i < 3; i++)
            {
                peso += 2;
            }

            MessageBox.Show("Peso: " + peso);

            while (idade < 18)
            {
                MessageBox.Show("Nao pode");
                idade++;
            }
                      
            // MessageBox.Show($"Preço da academia: {preco:C}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int valor = 15;
            string mensagem = "";

            mensagem = valor > 10 ? "Maior que dez" : "Menor que dez";

            MessageBox.Show(mensagem);
        }
    }
}
