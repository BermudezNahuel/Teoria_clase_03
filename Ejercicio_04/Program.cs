namespace Ejercicio_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lapicera azul = new Lapicera(ConsoleColor.Blue, 100);
            Lapicera red = new Lapicera(ConsoleColor.Red, 50);

            Console.ForegroundColor = azul.Color;
            Console.WriteLine(azul.Pintar(10));

            Console.ForegroundColor = red.Color;
            Console.WriteLine(red.Pintar(50));

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}