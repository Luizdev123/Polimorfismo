using System;

namespace Polimorfismo
{
    internal class Animal
    {
        // Método virtual para ser sobrescrito pelas classes derivadas
        public virtual void EmitirSom()
        {
            Console.WriteLine("Som de animal indefinido.");
        }
    }
}
