namespace iRh.Windows.Core
{
    public static class ValeTrasnporte
    {
        const double PercentualDesconto = 0.06;
        public static double Calcula( double salario)
        {
            var valorDesconto = salario * PercentualDesconto;
  
            return valorDesconto;

        }
    }
}
