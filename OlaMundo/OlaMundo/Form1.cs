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
            int idade = 25;
            double altura = 1.8;
            float peso = 95.5f;
            bool ehFumante = true;
            char sexo = 'M';

            decimal preco = 79.968464874m;

            MessageBox.Show($"Preço da academia: {preco:C}");
        }
    }
}
