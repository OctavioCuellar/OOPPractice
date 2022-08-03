using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{
    // Abstracción
    public abstract class Figura
    {
        // Herencia
        public int Base { get; set; }
        public int Altura { get; set; }
        public int Area { get; set; }
        public int Perimetro { get; set; }

        // Metodo virtual
        public virtual void Dibujar()
        {
            Console.WriteLine($"Dibujando figura");
        }

        public virtual int CalcularArea()
        {
            return Area;
        }

    }
}
