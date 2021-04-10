using System;

namespace Decisoes
{
    class Program
    {
        static void Main(string[] args)
        {
          string M = "M", F = "F", sexo;
          double pesom, pesof, alt;

          Console.Write("Digite sua altura em Metros..: ");
          alt = Convert.ToDouble(Console.ReadLine());

          Console.Write("Sexo [M]asculino / [F]eminino...:");
          sexo = Console.ReadLine();

          pesom = (alt * 72.7) - 58.0;
          pesof = (alt * 62.1) - 44.7;

          if (sexo == M) {

              
              Console.Write($"Seu peso ideal é {pesom:N1}");

          } else if (sexo == F) {

             
              Console.Write($"Seu peso ideal é {pesof:N1}");
          }




             


        }
    }
}
