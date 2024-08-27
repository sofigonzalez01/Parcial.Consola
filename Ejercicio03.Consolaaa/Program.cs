namespace Ejercicio03.Consolaaa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, cilindros!");
            double radio, altura;
            do
            {
                Console.WriteLine("ingrese el valor del radio: ");
                if (double.TryParse(Console.ReadLine(), out radio) && radio > 0)
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


            var perimetro = 2 * Math.PI * radio;
            var superficie = 2 * Math.PI * Math.Pow(radio, 2) + 2 * Math.PI * radio * altura;
            Console.WriteLine($"Cilindro de radio: {radio}");
            Console.WriteLine($"Altura: {altura}");
            Console.WriteLine($"perimetro: {perimetro}");
            Console.WriteLine($"superficie: {superficie}");

        }
    }
}
