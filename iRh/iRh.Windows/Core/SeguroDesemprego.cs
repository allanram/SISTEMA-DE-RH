namespace iRh.Windows.Core
{
    public static class SeguroDesemprego
    {
        public static double CalculaSeguroDesemprego(double salario1,double salario2,double salario3)
        {
            var mediaSalario = (salario1 + salario2 + salario3) / 3;

              double seguroDesemprego = 0;

               if(mediaSalario <= 1986.36)
               {
                seguroDesemprego = mediaSalario * 0.80;

                   return seguroDesemprego;
               }
               else if(mediaSalario<= 3280.93)
               {
                seguroDesemprego = (mediaSalario * 0.50) + 1574.69;

                   return seguroDesemprego;
               }
               else
               {
                seguroDesemprego = 2230.97;

                   return seguroDesemprego;
               }


           
        }
    }
}
