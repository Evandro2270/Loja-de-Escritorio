using System;
using System.Globalization;
namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                CultureInfo CI = CultureInfo.InvariantCulture;

                string produto1 = "Computador";
                string produto2 = "Mesa de escritório";

                byte idade = 30;
                int codigo = 5290;
                char genero = 'M';

                double preco1 = 2100.0;
                double preco2 = 650.50;
                double medida = 53.234567;

                Console.WriteLine("produtos: ");
                Console.WriteLine(produto1 + " , cujo o preço é $ " + preco1);
                Console.WriteLine(produto2 + " , cujo o preço é $ " + preco2);
                Console.WriteLine("{0}, cujo o preco é $ {1:F2}", produto1, preco1);
                Console.WriteLine("{0}, cujo o preco é $ {1:F2}", produto2, preco2);

                Console.WriteLine("Registro: " + idade + " anos de idade, codigo " + codigo + " e genero: " + genero);
                Console.WriteLine("Registro: {0} anos de idade, codigo {1} e genero: {2}", idade, codigo, genero);

                Console.WriteLine("Medida com oito casas decimais: " + medida.ToString("F8"));
                Console.WriteLine("Medida com oito casas decimais: {0:F8}", medida);

                Console.WriteLine("Arredondando (Tres casas decimais): " + medida.ToString("F3"));
                Console.WriteLine("Arredondando (Tres casas decimais): {0:F3}", medida);

                Console.WriteLine("Separador decimal CI: " + medida.ToString("F3", CI));


            }
        }
    }
}