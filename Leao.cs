using System;

namespace Polimorfismo
{
    internal class Leao : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine("ROAR!");
        }
    }
}
