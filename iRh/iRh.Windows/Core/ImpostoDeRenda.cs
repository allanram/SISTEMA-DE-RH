namespace iRh.Windows.Core
{
    public static class ImpostoDeRenda
    {
        // Faixas dos salarios
        const double Faixa1 = 1903.98;
        const double Faixa2 = 2826.65;
        const double Faixa3 = 3751.05;
        const double Faixa4 = 4464.68;
        // valores em porcentagem a serem multiplicados por Faixa

        const double PorcentagemFaixa1 =(0);
        const double PorcentagemFaixa2 =(7.5/100) ;
        const double PorcentagemFaixa3 =(15/100) ;
        const double PorcentagemFaixa4 =(22.5/100);
       
        public static double calculaImpostoDeRenda(double salario)
        {
            double descontoInss = Inss.Calcula(salario);
            double impostoRenda = salario - descontoInss;
            double descontoImpostoDeRenda = 0;

            if (salario <= Faixa1)
            {
                descontoImpostoDeRenda = (impostoRenda * PorcentagemFaixa1);
                return descontoImpostoDeRenda;
            }
           else if(salario<= Faixa2)
            {
                descontoImpostoDeRenda = (impostoRenda * PorcentagemFaixa2);
                return descontoImpostoDeRenda;
            }
           else if(salario<= Faixa3)
            {
                descontoImpostoDeRenda = (impostoRenda*PorcentagemFaixa3);
                return descontoImpostoDeRenda;
            }
           else if (salario <= Faixa4)
            {
                descontoImpostoDeRenda = (impostoRenda * PorcentagemFaixa4);
                return descontoImpostoDeRenda;
            }
           else
            {
                descontoImpostoDeRenda = (impostoRenda * 27.5 / 100);
                return descontoImpostoDeRenda;
            }


        }
    }
}
