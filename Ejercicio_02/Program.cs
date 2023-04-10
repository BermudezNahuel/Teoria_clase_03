namespace Ejercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Persona personaUno = new Persona("Juan", "16/12/2000", 37000000);
            Console.WriteLine(personaUno.Mostrar());
            Console.WriteLine(personaUno.EsMayorDeEdad());

            Persona personaTres = new Persona("Roberto", "16/12/2000", 38000000);
            Console.WriteLine(personaTres.Mostrar());
            Console.WriteLine(personaTres.EsMayorDeEdad());

            Persona personaDos = new Persona("carlos", "16/12/2010", 39000000);
            Console.WriteLine(personaDos.Mostrar());
            Console.WriteLine(personaDos.EsMayorDeEdad());
        
        
        }
    }
}