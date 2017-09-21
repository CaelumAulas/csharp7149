namespace Banco
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }

        public Cliente(string nome)
        {
            Nome = nome;
        }

        public Cliente(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
        }
        
        public Cliente()
        {

        }
    }
}