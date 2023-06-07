namespace iRh.Windows.Core
{
    public static class Periculosidade
    {
        const double PercentualPericulosidade = 0.3;
       public static double CalculaPericulosidade(double salario)
        {
            var valorPericulosidade = (salario * PercentualPericulosidade);
            return valorPericulosidade;
        }

    }
}
