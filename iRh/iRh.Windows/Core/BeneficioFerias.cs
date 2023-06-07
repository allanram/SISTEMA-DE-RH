namespace iRh.Windows.Core
{
    public static class BeneficioFerias
    {
        public static double CalculaFerias(double salario)
        {

            double valorFerias = (salario / 3) + salario - Fgts.Calcula(salario) - ImpostoDeRenda.calculaImpostoDeRenda(salario);
            double totalFerias = (valorFerias - salario);
            return totalFerias;
        }
    }
}
