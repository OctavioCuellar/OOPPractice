using System;

namespace OOPPractice
{
    public class Triangulo : Figura
    {
        public Triangulo(int a, int b)
        {
            Altura = a;
            Base = b;
        }

        public override void Dibujar()
        {
            Console.WriteLine($"Dibujando un triángulo");
            base.Dibujar();
        }

        // Formula del area triángulo equilátero
        // Polimorfismo
        // Sealed
        public sealed override int CalcularArea()
        {
            return (Base * Altura) / 2;
        }
    }
}
