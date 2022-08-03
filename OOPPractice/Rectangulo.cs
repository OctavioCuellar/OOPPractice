using System;

namespace OOPPractice
{
    internal class Rectangulo : Figura
    {
        public Rectangulo(int a, int b)
        {
            Altura = a;
            Base = b;
        }

        public override void Dibujar()
        {
            Console.WriteLine($"Dibujando un rectángulo");
            base.Dibujar();
        }

        // Polimorfismo a metodo abstract
        public override int CalcularArea()
        {
            return Base * Altura;
        }

    }
}
