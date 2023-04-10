using Geometria;
using System.Text;

namespace Ejercicio_05
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Punto puntoUno = new Punto(3, 4);
            Punto puntoDos = new Punto(7, 4);
            Punto puntoTres = new Punto(7, 1);
            Punto puntoCuatro = new Punto(3, 1);


            Rectangulo rectanguloUno = new Rectangulo(puntoUno, puntoDos, puntoTres, puntoCuatro);
          
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(DatosDelRectangulo(puntoUno,puntoDos,puntoTres,puntoCuatro));

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Area del Rectangulo: " + Convert.ToString(rectanguloUno.Area()));
            Console.WriteLine("Perimetro del Rectangulo: " + Convert.ToString(rectanguloUno.Perimetro()));

            Console.ForegroundColor= ConsoleColor.White;
        }





        static string DatosDelRectangulo(Punto puntoUno, Punto puntoDos, Punto puntoTres, Punto puntoCuatro)
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("===========================");
            sb.AppendLine($"Vertice 1: ({puntoUno.GetX()}, {puntoUno.GetY()})");
            sb.AppendLine($"Vertice 1: ({puntoDos.GetX()}, {puntoDos.GetY()})");
            sb.AppendLine($"Vertice 1: ({puntoTres.GetX()}, {puntoTres.GetY()})");
            sb.AppendLine($"Vertice 1: ({puntoCuatro.GetX()}, {puntoCuatro.GetY()})");
            sb.AppendLine("===========================");
            return sb.ToString();
        }
    }
}