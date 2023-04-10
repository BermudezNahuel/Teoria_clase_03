namespace Ejercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante alumnoUno = new Estudiante("Gonzalez", "Marcos", 123);
            Estudiante alumnoDos = new Estudiante("Martinez", "Juan", 145);
            Estudiante alumnoTres = new Estudiante("Juarez", "Magali", 568);

            alumnoUno.SetNotaPrimerParcial(7);
            alumnoUno.SetNotaSegundoParcial(7);
            
            alumnoDos.SetNotaPrimerParcial(3);
            alumnoDos.SetNotaSegundoParcial(7);
            
            alumnoTres.SetNotaPrimerParcial(5);
            alumnoTres.SetNotaSegundoParcial(8);

            Console.WriteLine(alumnoUno.Mostrar());
            Console.WriteLine(alumnoDos.Mostrar());
            Console.WriteLine(alumnoTres.Mostrar());



        }
    }
}