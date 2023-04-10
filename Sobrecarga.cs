using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teoria_clase_03
{
    internal class PersonaDos
    {

        //Puedo crear constructores que asignan atributos diferentes, uno que asigne el DNI y otro Nomnbre y apellido
        //Es una tecnica que nos permite definir varios miembros de una clase con el mismo nombre. Siempre y cuando reciban un conjunto 
        //distintos de parametros. Puedo sobrecargar: metodos, operadores e indexadores.

        private string _nombre;
        public string Nombre
        { get => _nombre;
            set => _nombre = value;
        }

        private string _apellido;
        public string Apellido
        {
            get => _apellido;
            set => _apellido = value;
        }


        private int _dni;
        private int Dni
        {
            get => _dni;
            set => _dni = value > 10000000 ? value : 0;
        }

        public PersonaDos(string nombre, string apellido, int dni)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
        }
        //SOBRECARGA DE METODO COSNTRUCTOR
        public PersonaDos(int dni)
        {
            //Nos permite inicializar un objeto con solo el atributo DNI, y luego 
            //agregar los atributos que faltan
            Dni = dni;
        }

        //Sobrecarga de un Operaodres:
        /*
         * Operadores: 
         * Unarios: ++, --, !, +, *, treu, false
         *  
         */

        public static bool operator == (PersonaDos p1, PersonaDos p2) 
        {
            return p1.Dni == p2.Dni;

        }
        public static bool operator !=(PersonaDos p1, PersonaDos p2)
        {
            return !(p1.Dni == p2.Dni);

        }

        //Con este nuevo oerador puedo ver si dos personas son iguales comprando el atributo DNI de las mismas.
        //De esta manera puedo comparar el DNI de dos objetos en Program.cs ==> Console.WriteLine(p1 == p2) ==> Retornara True o False 
        //Tambien estoy encapsulando en mi clase que pasa cuand se usa el operador ==



    }
}
