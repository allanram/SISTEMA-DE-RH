namespace iRh.Windows.Core
{
    public static class Fgts
    {
        const double PorcentagemFgts = 0.08;
        public static double Calcula(double salario)
        {
             var valorFgts = salario * PorcentagemFgts;
             var contribuicaoFgts = valorFgts;

            return contribuicaoFgts;
        }
    }
}
