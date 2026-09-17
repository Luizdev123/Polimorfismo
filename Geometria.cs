namespace Abstracao
{
    internal class Geometria
    {
        public double CalcularArea(double lado)
        {
            return lado * lado;
        }

        public double CalcularArea(double baseRetangulo, double altura)
        {
            return baseRetangulo * altura;
        }

        public double CalcularArea(double raio, bool isCirculo)
        {
            return Math.PI * raio * raio;
        }
    }
}