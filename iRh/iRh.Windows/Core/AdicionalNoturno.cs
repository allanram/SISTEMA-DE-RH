namespace iRh.Windows.Core
   
{
    public static class AdicionalNoturno
    {
        const double HorasContratuais = 220;
        const double PercentualAdicional = 0.2;
        public static double calcula(double salario,int horasNoturnasTrabalhadas)
        {
            var valorAdiconal = (salario / HorasContratuais) * horasNoturnasTrabalhadas*PercentualAdicional;
            return valorAdiconal;
        }
    }
}
