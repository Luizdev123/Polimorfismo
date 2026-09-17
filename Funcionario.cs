using System;

namespace Polimorfismo
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public double Salario { get; set; }

        public virtual double CalcularBonusAnual()
        {
            return Salario * 0.10; // 10% do salário
        }
    }

    public class Gerente : Funcionario
    {
        public override double CalcularBonusAnual()
        {
            return Salario * 0.15 + 1000; // 15% do salário + bônus fixo de R$1000
        }
    }

    public class Desenvolvedor : Funcionario
    {
        public override double CalcularBonusAnual()
        {
            return Salario * 0.12; // 12% do salário
        }
    }
}
