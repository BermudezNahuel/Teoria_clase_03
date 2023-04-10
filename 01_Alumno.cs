using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teoria_clase_03
{
    internal class Alumno
    {
        //atributos públicos
        public string nombre; 
        public string apellido;
        //atributos privados, es una manera de protejer los archivos para que no sean modificados
        private int legajo;

        public void SetLegajo(int legajo)// Con este método puedo modificar este atributo fuera de la clase
        {
            this.legajo = legajo;// se utiliza el THIS para hacer referencia al atributo legajo que se
            //encuentra fuera de este bloque
        }

        public int GetLegajo()//Con este método puedo ver los atributos priv fuera de la clase
        {
            return legajo;
        }


        public string Divisor()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("===========");
            //b.AppendLine($"Cantidad: {cantidad}");
            return sb.ToString();
        }
    }




}
