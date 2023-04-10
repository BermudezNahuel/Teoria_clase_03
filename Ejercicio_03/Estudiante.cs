using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    internal class Estudiante
    {
        private string _apellido;
        private string _nombre;
        private int _legajo;
        private int _notaPrimerParcial;
        private int _notaSegundoParcial;
        private static Random _random;
        

        public Estudiante(string apellido, string nombre, int legajo)
        {
            _apellido = apellido;
            _nombre = nombre;
            _legajo = legajo;
        }

        static Estudiante()
        {
            _random = new Random();
        }

        public void SetNotaPrimerParcial(int nota)
        {
            _notaPrimerParcial = nota;
        }
        public void SetNotaSegundoParcial(int nota)
        {
            _notaSegundoParcial = nota;
        }

        private double CalcularPromedio()
        {
            double promedio = (_notaPrimerParcial + _notaSegundoParcial) / 2;
            return promedio;
        }

        public int CalcularNotaFinal() 
        { 
            if (_notaSegundoParcial >= 4 && _notaPrimerParcial >= 4)
            {
                return _random.Next(6,10);
            }
            else
            {
                return -1;
            }
   
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("========================");
            sb.AppendLine($"Nombre: {_nombre}");
            sb.AppendLine($"Apellido: {_apellido}");
            sb.AppendLine($"Legajo: {_legajo}");
            sb.AppendLine($"Nota de Primer Parcial: {_notaPrimerParcial}");
            sb.AppendLine($"Nota de Segundo Parcial: {_notaSegundoParcial}");
            
            double promedio = CalcularNotaFinal();

            if (promedio > 0)
            {
                sb.AppendLine($"Nota Final: {promedio}");
            }
            else
            {
                sb.AppendLine($"Nota Final: Alumno Desaprobado");
            }
            
            sb.AppendLine("========================");
            return sb.ToString();
        }





    }
}
