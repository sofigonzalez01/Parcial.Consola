using Microsoft.VisualBasic;

namespace Ejercicio02.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, cilindros");
            double maxVolumen = double.MinValue; 
            int iteracionMaxVolumen = 0; 
            int iteracionActual = 1;
            double sumaSuperficies = 0;
            int contadorCilindros = 0;




            while (true)
            {
                Console.WriteLine("Ingrese los datos del cilindro:");

                double radio = ObtenerDato("Ingrese el radio del cilindro: ");
                double altura = ObtenerDato("Ingrese la altura del cilindro: ");

                double volumen = CalcularVolumen(radio, altura);
                double superficie = CalcularSuperficie(radio, altura);

                Console.WriteLine($"\nVolumen del cilindro: {volumen:F2}");
                Console.WriteLine($"Superficie del cilindro: {superficie:F2}\n");
                sumaSuperficies += superficie;
                contadorCilindros++;
                if (contadorCilindros > 0)
                {
                    double promedioSuperficie = sumaSuperficies / contadorCilindros;
                    Console.WriteLine($"\nPromedio de las superficies de los cilindros: {promedioSuperficie:F2} unidades cuadradas");
                }
                else
                {
                    Console.WriteLine("No se ingresaron cilindros.");
                }

                if (volumen > maxVolumen)
                {
                    maxVolumen = volumen;
                    iteracionMaxVolumen = iteracionActual;
                }
              
                if (maxVolumen > double.MinValue)
                {
                    
                    
                    Console.WriteLine($"El cilindro con el mayor volumen fue ingresado en la iteración número {iteracionMaxVolumen}.");
                    Console.WriteLine($"Volumen del cilindro con el mayor volumen: {maxVolumen:F2} unidades cúbicas");
                }
                



                Console.Write("¿Desea ingresar otro cilindro? (s/n): ");
                string continuar = Console.ReadLine().Trim().ToLower();
                if (continuar != "s")
                {
                    break;
                }
            }
        }

        static double ObtenerDato(string mensaje)
        {
            while (true)
            {
                Console.Write(mensaje);
                string entrada = Console.ReadLine();

                if (double.TryParse(entrada, out double valor) && valor > 0)
                {
                    return valor;
                }

                Console.WriteLine("Entrada no válida. El valor debe ser un número positivo.");
            }
        }

       private static double CalcularVolumen(double radio, double altura)
        {
            return Math.PI * Math.Pow(radio, 2) * altura;
        }

       private static double CalcularSuperficie(double radio, double altura)
        {
            return 2 * Math.PI * radio * (radio + altura);
        }
    }
}

