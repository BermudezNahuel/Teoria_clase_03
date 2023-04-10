namespace Teoria_clase_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Alumno alumnoUno;
            alumnoUno = new Alumno();
            alumnoUno.nombre = "Jose";
            alumnoUno.apellido = "Caceres";
            // no puedo acceder al atributo legajo del objeto ya que es un atributo privado, debo utilizar
            //un método para poder mofidicarlo


            Console.WriteLine(alumnoUno.Divisor());
            //utilizo console.writeline para mostrar los atributos por consola
            Console.WriteLine(alumnoUno.apellido + " " + alumnoUno.nombre); // de esta manera muestro los
            //atributos apellido y nombre separados por un espacio


            Console.WriteLine(alumnoUno.Divisor());
            alumnoUno.SetLegajo(114);// Llamo al metodo SetLegajo del Objeto alumnoUno y le asigno un valor
            Console.WriteLine("Numero de legajo: " + alumnoUno.GetLegajo());//Llamo al método GetLegajo del objeto alumnoUno para mostrar el valor
            //por consola


            Alumno2 alumnoDos = new Alumno2("garcia","perez",100);
            /*En esta nueva clase ya no puedo modificar el atributo nombre,apellido y legajo
            
            Tampoco voy a poder mostrar los datos llamando al objeto.atributo
            
            Console,WriteLine(alumnoDos.nombre);
            No mostraria nada por consola ya que nombre es un atributo privado.
            
            Para resolverlo deberia crear un metodo en la clase que sea publico y que me permita
            ver toda la info, o la info que yo quiera mostrar
            
            */
            Console.WriteLine(alumnoDos);//Ahora se esta aplicando el metodo ToString() ya que le paso
                                         //al Console.WriteLine un objeto como string. Implicitamente se le aplica el metodo ToString()

            Console.WriteLine(alumnoDos.GetDatos());//Metodo que hace lo mismo que ToString()
            

        }

    }
}