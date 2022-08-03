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
        // Herencia y encapsulación
        public int Base { get; set; }
        public int Altura { get; set; }

        // Metodo virtual, que tengan un comportamiento específico y los hijos puedan sobreescribirlo
        public virtual void Dibujar()
        {
            Console.WriteLine($"Dibujando figura"); // Implementación
        }

        // Método abstracto, usamos abstract cuando queremos que los hijos sobreescriban este método
        public abstract int CalcularArea(); // Definición / Abstracción / Firma

    }
}
