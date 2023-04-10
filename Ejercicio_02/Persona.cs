using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    internal class Persona
    {
        private string _nombre;
        private string _fechaDeNacimiento;
        private int _dni;
        private DateTime resultado;
    
        public Persona(string nombre,string fechaDeNacimiento, int dni)
        {
            _nombre = nombre;
            _fechaDeNacimiento = fechaDeNacimiento;
            _dni = dni;
        }

        public string Nombre {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string _FechaDeNacimiento
        {
            get {return _fechaDeNacimiento; }
            set { _fechaDeNacimiento = value; }
        }

        public int Dni
        {   
            //con funcion lambda
            get => _dni;
            set => _dni = value;
        }

        public int CalcularEdad()
        {
            int anioNacimiento = DateTime.Parse(_fechaDeNacimiento).Year;
            int anioactual = DateTime.Now.Year;
            int edadactual = anioactual-anioNacimiento;

            return edadactual;

        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("--------------");
            sb.AppendLine($"Nombre: {_nombre}");
            sb.AppendLine($"Fecha de Nacimiento: {_fechaDeNacimiento}");
            sb.AppendLine(Convert.ToString(CalcularEdad()));
            sb.AppendLine("--------------");
            return sb.ToString();
        }

        public string EsMayorDeEdad()
        {
            string mensaje;

            if (CalcularEdad() > 17)
            {
                mensaje = "Es mayor de edad";
            }
            else
            {
                mensaje = "Es menor de edad";
            }

            return mensaje;

        }

        















    }


}
