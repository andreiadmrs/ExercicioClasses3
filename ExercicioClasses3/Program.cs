using System;
using System.Globalization;

namespace ExercicioClasses3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Fazer um programa para ler os valores da largura e altura
            de um retângulo. Em seguida, mostrar na tela o valor de
            sua área, perímetro e diagonal. Usar uma classe como
            mostrado no projeto ao lado.*/
            var retangulo = new Retangulo();

            Console.WriteLine("Digite largura do retangulo:");
            retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite altura do retangulo:");
            retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Area: "+retangulo.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perímetro: "+ retangulo.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal: " + retangulo.Diagonal().ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
