namespace BancoFuncionario
{
    public class ControleDeBonificacao
    {
        public double Total { get; private set; }

        public void Adiciona(Funcionario f)
        {
            Total += f.Bonificacao();
        }
    }
}