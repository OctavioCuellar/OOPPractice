namespace OOPPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var figuras = new List<Figura>
            {
                new Rectangulo(5, 10),
                new Cuadrado(5),
                new Triangulo(10, 15)
            };

            foreach (var figura in figuras)
            {
                figura.Dibujar();
            }

            Console.WriteLine($"\nEl area del rectángulo es: {figuras[0].CalcularArea()}\n");
            Console.WriteLine($"El area del cuadrado es: {figuras[1].CalcularArea()}\n");
            Console.WriteLine($"El area del triángulo es: {figuras[2].CalcularArea()}\n");

            // Manejo de excepciones
            Console.WriteLine($"Introduzca un valor numerico para el lado del cuadrado:");
            try
            {
                int ladoCuadrado = Convert.ToInt32(Console.ReadLine());                
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"El valor introducido no era un numero entero, código de error: {ex}");
            }

            Console.ReadLine();

        }
    }
}