using System;
using System.Globalization;
namespace ListaDeExercicios2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problema 00 = Negativo
            int num1 = int.Parse(Console.ReadLine());
            if (num1 < 0)
            {
                Console.WriteLine("Negativo");
            } else {
                Console.WriteLine("Não Negativo");
            }
            
            //Problema 01 = Par ou Impar
            int num2 = int.Parse(Console.ReadLine());
            if (num2 % 2 == 0) { Console.WriteLine("Par"); } else { Console.WriteLine("Impar"); } 
            
            //Problema 02 = Multiplos
            int num3 = int.Parse(Console.ReadLine()), num4 = int.Parse(Console.ReadLine());
            if (num3 % num4 == 0 || num4 % num3 == 0) { Console.WriteLine("São multiplos"); } else { Console.WriteLine("Não são multiplos"); }
            
            //Problema 03 = Horas jogadas
            int num5 = int.Parse(Console.ReadLine()), num6 = int.Parse(Console.ReadLine()), duracao;
            if (num5 < num6) { duracao = num6 - num5; } else { duracao = 24 - num5 + num6; }
            Console.WriteLine($"O jogo durou {duracao} Hora(s)");
            
            //Problema 04 = Lancheria
            int cod = int.Parse(Console.ReadLine()), quant = int.Parse(Console.ReadLine());
            double preco = 0.0;
            if (cod == 1) { preco = 4 * quant; }
            else if (cod == 2) { preco = 4.5 * quant; }
            else if (cod == 3) { preco = 5 * quant; }
            else if (cod == 4) { preco = 2 * quant; }
            else if (cod == 5) { preco = 5 * quant; }

            Console.WriteLine($"Total = R${preco.ToString("F2", CultureInfo.InvariantCulture)}");
            
            //Problema 05 = Dentro de um intervalo
            double num7 = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));
            if (num7 >= 00.00 && num7 <= 25.00) { Console.WriteLine("Intervalo = [0,25]"); }
            else if (num7 > 25.00 && num7 <= 50.00) { Console.WriteLine("Intervalo = [25,50]"); }
            else if (num7 > 50.00 && num7 <= 75.00) { Console.WriteLine("Intervalo = [50,75]"); }
            else if (num7 > 75.00 && num7 <= 100.00) { Console.WriteLine("Intervalo = [75,100]"); }
            else { Console.WriteLine("Fora do intervalo"); }
            
            //Problema 06 = Quadrantes
            string[] vet = Console.ReadLine().Split(' ');
            double x = double.Parse(vet[0]), y = double.Parse(vet[1]);
            if (x == 0 && y != 0) { Console.WriteLine("No eixo Y"); } 
            else if (x != 0 && y == 0) { Console.WriteLine("No eixo X"); }
            else if (x > 0 && y > 0) { Console.WriteLine("Q1"); } 
            else if (x < 0 && y > 0) { Console.WriteLine("Q2"); } 
            else if (x < 0 && y < 0) { Console.WriteLine("Q3"); }
            else if (x > 0 && y < 0) { Console.WriteLine("Q4"); }
            else { Console.WriteLine("Origem"); }
            
            //Problema 07 = Imposto de renda
            /*
              0 - 2000.00 = isento
              2000.01 - 3000.00 = 8%
              3000.01 - 4500.00 = 18%
              4500.01 - acima = 28%
             */ 
            double num8 = double.Parse(Console.ReadLine()), aPagar = 00.00;

            if (num8 > 2000 && num8 <= 3000) { Console.WriteLine( $"Pagar = R${(aPagar = (num8 - 2000) * 0.08).ToString("F2", CultureInfo.InvariantCulture)}"); } 
            else if (num8 > 3000.00 && num8 <= 4500) { Console.WriteLine( $"Pagar = R${(aPagar = (num8 - 3000) * 0.18 + 1000 * 0.08).ToString("F2", CultureInfo.InvariantCulture)}"); } 
            else if (num8 > 4500.00) { Console.WriteLine( $"Pagar = R${(aPagar = (num8 - 4500) * 0.28 + 1500 * 0.18 + 1000 * 0.08).ToString("F2", CultureInfo.InvariantCulture)}"); } 
            else { Console.WriteLine("Isento"); }
        }
    }
}