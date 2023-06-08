namespace iRh.Windows.Core
{
    public static class Pis
    {
        const double ValorMes = 108.50;
       
        public static double CalculaPis(double salario,double mesesTrabalhados)
        {

            if (salario < 2604.0)
            {

                return 0;

            }
            else 
            {

                var valorPis = ValorMes * mesesTrabalhados;
                return valorPis;

            }
            
        }
    }
}
