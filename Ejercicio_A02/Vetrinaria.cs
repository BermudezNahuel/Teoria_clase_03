using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ejercicio_A02
{
    internal class Duenio
    {
        private string _name;
        private string _apellido;
        private string _domicilio;
        private string _telefono;


        public string Name { get => _name; }
        public string Apellido { get => _apellido; }
        public string Domicilio { get => _domicilio; }
        public string Telefono { get => _telefono; }

        public Duenio(string name, string apellido, string domicilio, string telefono)
        {
            _name = name;
            _apellido = apellido;
            _domicilio = domicilio;
            _telefono = telefono;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            //sb.AppendLine("=====================");
            sb.AppendLine($"Nombre Dueño: {_name}");
            sb.AppendLine($"Apellido Dueño: {_apellido}");
            sb.AppendLine($"Domicilio Dueño: {_domicilio}");
            sb.AppendLine($"Telefono Dueño: {_telefono}");
            //sb.AppendLine("=====================");
            return sb.ToString();
        }

    }


    internal class Mascota
    {
        private string _especie;
        private string _name;
        private string _fechaNacimiento;
        private string _vacunas = "";
        private string _nonmbreDuenio;
        private string _apellidoDuenio;
        private string _domicilioDuenio;
        private string _telefonoDuenio;



        public string Especie { get => _especie; }
        public string Name { get => _name; }
        public string FechaDeNacimiento { get => _fechaNacimiento;}
        public string Vacunas { get => _vacunas; }

        public Mascota(string especie, string name, string fechaDeNacimiento, string vacunas, string nombreDuenio, string apellidoDuenio, string domicilioDuenio, string telefonoDuenio)
        {
            _especie = especie;
            _name = name;
            _fechaNacimiento = fechaDeNacimiento;
            _vacunas = vacunas;
            _nonmbreDuenio = nombreDuenio;
            _apellidoDuenio = apellidoDuenio;
            _domicilioDuenio = domicilioDuenio;
            _telefonoDuenio = telefonoDuenio;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("===== Datos de la mascota =================");
            sb.AppendLine($"Nombre: {_especie}");
            sb.AppendLine($"Nombre: {_name}");
            sb.AppendLine($"Fecha Nacimiento: {_fechaNacimiento}");
            sb.AppendLine($"Vacunas: {_vacunas}");
            sb.AppendLine("");
            sb.AppendLine("==== Datos del Duenio =====================");
            sb.AppendLine($"Nombre Dueño: {_nonmbreDuenio}");
            sb.AppendLine($"Apellido Dueño: {_apellidoDuenio}");
            sb.AppendLine($"Domicilio Dueño: {_domicilioDuenio}");
            sb.AppendLine($"Telefono Dueño: {_telefonoDuenio}");
            return sb.ToString();

        }

    }
}
