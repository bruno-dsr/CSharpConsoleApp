namespace Classes4{
    public static class ConversorDeMoeda{

        public static double IOF = 6.0;

        public static double CalcularValorTotal(double cotacao, double valor){
            double total = valor * cotacao;
            double imposto = (valor * (IOF/100)) * cotacao;
            return total + imposto;
        }
    }
}