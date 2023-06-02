namespace iRh.Windows.Core
{
    public static class Inss

    {
        // Faixas dos salarios
        const double Faixa1 = 1302.0;
        const double Faixa2 = 2571.29;
        const double Faixa3 = 3856.94;
        const double Faixa4 = 4464.68;

        // valores em porcentagem a serem multiplicados por Faixa
        const double PorcentagemFaixa01 =(0.07);
        const double PorcentagemFaixa02 = (0.09);
        const double PorcentagemFaixa03 = (0.12);
        const double PorcentagemFaixa04 = (0.14);
        public static double Calcula(double salario)
        {


           
            double desconto = 0;
            double valorInss = desconto;

            if (salario <= Faixa1)
            {
                desconto = (salario * PorcentagemFaixa01);
                return desconto;

            }
            else if (salario <= Faixa2)
            {
                desconto = (salario * PorcentagemFaixa02);
                return desconto;

            }
            else if (salario <= Faixa3)
            {
                desconto = (salario * PorcentagemFaixa03);
                return desconto;
            }
            else
            {
                desconto = (salario * PorcentagemFaixa04);
                return desconto;
            }


        }
       

    }

    

    

   

}
