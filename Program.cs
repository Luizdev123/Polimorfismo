using System;
using System.Collections.Generic;
using Polimorfismo;

namespace Abstracao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Geometria geometria = new Geometria();

            double areaQuadrado = geometria.CalcularArea(5);
            double areaRetangulo = geometria.CalcularArea(10, 4);
            double areaCirculo = geometria.CalcularArea(3, true);

            Console.WriteLine("Area do quadrado: " + areaQuadrado);
            Console.WriteLine("Area do retangulo: " + areaRetangulo);
            Console.WriteLine("Area do circulo: " + areaCirculo);

            // Exemplo com herança e polimorfismo: Funcionários
            Gerente gerente = new Gerente { Nome = "Carlos", Salario = 8000 };
            Desenvolvedor desenvolvedor = new Desenvolvedor { Nome = "Ana", Salario = 5000 };

            Console.WriteLine();
            Console.WriteLine("Bônus anual - Gerente (" + gerente.Nome + "): R$ " + gerente.CalcularBonusAnual());
            Console.WriteLine("Bônus anual - Desenvolvedor (" + desenvolvedor.Nome + "): R$ " + desenvolvedor.CalcularBonusAnual());

            // Exemplo de polimorfismo com animais
            Console.WriteLine();
            Console.WriteLine("Exemplo de Polimorfismo - Animais:");
            var animais = new List<Animal> { new Leao(), new Macaco(), new Cobra() };
            foreach (var animal in animais)
            {
                animal.EmitirSom();
            }
        }
    }
}
