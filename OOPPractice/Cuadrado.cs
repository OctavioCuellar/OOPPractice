using System;

namespace OOPPractice
{
    public class Cuadrado : Figura
    {
        // Encapsulamiento
        private int _lado;

        public Cuadrado(int lado)
        {
            _lado = lado;
        }

        public override void Dibujar()
        {
            Console.WriteLine($"Dibujando un cuadrado");
            base.Dibujar();
        }

        // Polimorfismo
        public override int CalcularArea()
        {
            return _lado * _lado;
        }

    }
}
