namespace iRh.Windows.Core
{
    

     public static class HorasExtras
    {
        const double HorasMensais = 220;
        const double HorasExtra50 = 1.5;
        const double HorasExtras100 = 1.6;

        public static double CalculaHorasExtras50(double salario, int horasExtras) // Calcula Horas Extras sem feriados e finais de semanas
        {
            var valorExtra = (salario/ HorasMensais);
            var horaExtra50= (valorExtra * HorasExtra50) * horasExtras;
            
            return horaExtra50;
        }
        public static double CalculaHorasExtras100(double salario, int horasExtras)// inclui finais de semana e feriados 
        {
            var valorExtra = (salario / HorasMensais);
            var horaExtra100 = (valorExtra * HorasExtras100) * horasExtras;
            
            
            return horaExtra100;
        }
          
    } 
}
