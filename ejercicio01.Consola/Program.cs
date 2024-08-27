using Microsoft.VisualBasic;

namespace ejercicio01.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, cilindro");
            double radio, altura;
            do
            {
                Console.WriteLine("ingrese el valor del radio: ");
                if (double.TryParse(Console.ReadLine(), out radio)&& radio>0)
                {
                    break;
                }
                Console.WriteLine("radio mal ingresada");
            } while (true);
            do
            {
                Console.WriteLine("ingrese la altura: ");
                if (double.TryParse(Console.ReadLine(), out altura) && altura > 0)
                {
                    break;
                }
                Console.WriteLine("altura mal ingresada");
            } while (true);
           

            var volumenCilindro = Math.PI * Math.Pow(radio, 2) * altura;
            var superficie = 2 * Math.PI * Math.Pow(radio, 2) + 2 * Math.PI * radio * altura;
            Console.WriteLine($"Cilindro de radio: {radio}");
            Console.WriteLine($"Altura: {altura}");
            Console.WriteLine($"Volumen: {volumenCilindro}");
            Console.WriteLine($"superficie: {superficie}");

        }
    }
}
