using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teoria_clase_03
{
    internal class Alumno2
    {
        private string name;
        private string apellido;
        private int legajo;

        public int Legajo 
        { 
            get => legajo;
            set => legajo = value > 100000 ? value : 0;
        }

        //Constructor, permite inicializar el objeto (pasandole los atributos como parametros), de esta manera el objeto
        //se instancia una sola vez.
        //El constructor se declara con public Nombre_de_la_Clase(argumento1,argumento2,etc){}


        public Alumno2(string name, string apellido,int legajo)
        {
            this.name = name;
            this.apellido = apellido;
            this.legajo = legajo;

            //Utilizo this para hacer referencia a las atributos que se encuentran fuera de este bloque. Tambien
            //se utiliza el THIS ya que existira una ambigüedad con respecto al nombre de las variables.
        }

        //Ahora ya tengo un contructor de clase, y ya no es necesario crear un metodo Setter para
        //asignar un valor a los atributos privados del objeto, estos se deben declarar cuando se instancia la clase.


        //--------------------------------------------------------------------------------------------------------------------

        
        //Existe un metodo que se heredo de object y que se ejecuta cuando usamos un objeto como un string
        //objeto.ToString()
        //Pero puedo modificar el comportamiento de ToString, sobreescrbiendo su comportamiento:

        public override string ToString()
        {
            //Creo un StringBuilder
            StringBuilder sb = new StringBuilder();//Instancio un objeto de la clase StringBuilder
            sb.AppendLine("====================");
            sb.AppendLine($"Nombre: {name}");
            sb.AppendLine($"Apellido: {apellido}");
            sb.AppendLine($"Legajo: {legajo}");
            sb.AppendLine("=====================");
            return sb.ToString();
        }

        //Tambien puedo crear un método que hago lo mismo, pero para utilizarlo fuera de la clase, debere pásarle el metodo


        public string GetDatos()
        {
            //Creo un StringBuilder
            StringBuilder sb = new StringBuilder();//Instancio un objeto de la clase StringBuilder
            sb.AppendLine("====================");
            sb.AppendLine($"Nombre: {name}");
            sb.AppendLine($"Apellido: {apellido}");
            sb.AppendLine($"Legajo: {legajo}");
            sb.AppendLine("=====================");
            return sb.ToString();
        }

        //Todo esto se llama encapsulamiento, permite ocultar cierta comportamientos de la clase a los usuarios programadores.
        /*
         Existe caracteristicas especiales en la POO 
        -Encapsulación
        -Abstraccion: tener caracteristicas eseciales para resolver problemas que estamos buscando resolver 
        -Herencia: propiedad que tiene de compartir o reutilizar comportamientos definidos en otra clase. ejemplo ToString
        -Polimorfismo: comportamientos diferentes asociados a objetos distintos y que pueden compartir el mismo nombre. 
        Objetos diferentes que pueden hacer la misma acción
          
        Software tiene que tener un alto nivel de cohesion y bajo nivel de acomplamiento. 
        Cohesion: es la dependencia que tiene una clase de sus propios metodos.La clase depende mucho de los metodos declararos en ella.
                   En una clase todos los metodos tienen un mismo proposito que podemos reutilizar. Los metodos realizan una tarea similar,
                    no hacen lo mismo.
        Acoplamiento: es la dependencia entre 2 software entre si, es decir, la dependencia entre 2 clases entre si.Una clase tiene un alto
                        acoplamiento si utliza mucho otras clases( esto no es bueno, porque si cambio una clase, y esta es utilizada por otras
                        clases va a ser muy dificil el mantenimiento de la misma.
        
        La herencia esta bien cuando la utilizamos para reutilizar comportamiento o atributos.


         */


        //Metodo Equals para comparar objetos, devuelve un booleano.

        public bool Equals(Alumno2 alumno)
        {
            return legajo == alumno.legajo;
        }

        //readoly
        //requiered
        


        //Si quiero que un setter sea privado, es decir que solo lo use en la instancia. Si quiero que lo utilicen siempre lo dejo
        //como public.
        //Si solamente quiero quiero setarlo una sola vez utilizo INIT en vez de SETTER




    }
}
