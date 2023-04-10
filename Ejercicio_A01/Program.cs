using System.Text;

namespace Ejercicio_A01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conductor juan = new Conductor("Juan", 100, 200, 300, 400, 500, 600, 700);
            Conductor roberto = new Conductor("Roberto", 200, 300, 400, 0 , 500, 0, 800);
            Conductor alejandro = new Conductor("Alejandro", 200, 300, 400, 0 , 500, 0, 800);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(ConductorConMasKilometros(juan,roberto,alejandro));

            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine(ConductorMasKmDiaX(2,juan, roberto, alejandro));

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(ConductorMasKmDiaX(4, juan, roberto, alejandro));

            Console.ForegroundColor = ConsoleColor.White;
        }

        static string ConductorConMasKilometros(Conductor conductorUno, Conductor conductorDos, Conductor conductorTres)
        {
            string conductorMaskilometraje = conductorTres.Name;

            if (conductorUno.KilometrosPorSemana() > conductorDos.KilometrosPorSemana() && conductorUno.KilometrosPorSemana() > conductorTres.KilometrosPorSemana())
            {
                conductorMaskilometraje = conductorUno.Name;
            }
            else if (conductorDos.KilometrosPorSemana() > conductorTres.KilometrosPorSemana())
            {
                conductorMaskilometraje = conductorDos.Name;
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("======================");
            sb.AppendLine($"Conductor con mas kilometros en la semana {conductorMaskilometraje}");
            sb.AppendLine("======================");

            return sb.ToString();
        
        }

        static string ConductorMasKmDiaX(int dia,Conductor conductorUno, Conductor conductorDos, Conductor conductorTres)
        {
            string conductorMaskilometrajeDiaX = conductorTres.Name;
            if (conductorUno.Kilometros(dia) > conductorDos.Kilometros(dia) && conductorUno.Kilometros(dia) > conductorTres.Kilometros(dia))
            {
                conductorMaskilometrajeDiaX = conductorUno.Name;
            }
            else if(conductorDos.Kilometros(dia) > conductorTres.Kilometros(dia))
            {
                conductorMaskilometrajeDiaX = conductorDos.Name;
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("======================");
            sb.AppendLine($"Conductor con mas kilometros en el dia {dia} es {conductorMaskilometrajeDiaX}");
            sb.AppendLine("======================");

            return sb.ToString();
        }
    }
}