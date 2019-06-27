using System;

namespace EP3{
    public class Exercicio2{
        public void EX2(){
            string coord = "x";

            while (coord != ""){
                Console.WriteLine("Entre com as coordenadas");
                string[] xy = Console.ReadLine().Split(' ');
                int x = int.Parse(xy[0]);
                int y = int.Parse(xy[1]);

                coord = CalcularCoordenadas(x, y);
                Console.WriteLine(coord);
            }
        }

        private string CalcularCoordenadas(int x, int y){
            if(x == 0 || y == 0){
                return "";
            }
            else if (x > 0 && y > 0){
                return "Primeiro";
            }
            else if (x > 0 && y < 0){
                return "Segundo";
            }
            else if (x < 0 && y < 0){
                return "Terceiro";
            }
            else{
                return "Quarto";
            }
        }
    }
}