namespace Ejercicio_A02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Duenio duenioUno = new Duenio("Roberto", "Caceres", "Av Siempre Viva", "42220607");
            Mascota mascotaUno = new Mascota("Felino", "Odiseo", "20/11/2020", "Triple Felina", duenioUno.Name,duenioUno.Apellido,duenioUno.Domicilio, duenioUno.Telefono);


            Console.WriteLine(mascotaUno.Mostrar());

            Duenio duenioDos = new Duenio("Cesar", "Gutierez", "Av Cordoba", "42016598");
            Mascota mascotaDos = new Mascota("Canino", "Rayo", "15/02/210", "", duenioDos.Name, duenioDos.Apellido, duenioDos.Domicilio, duenioDos.Telefono);


            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(mascotaDos.Mostrar());

            Duenio duenioTres = new Duenio("Oscar", "Mendez", "Av Mitre", "42229878");
            Mascota mascotaTres = new Mascota("Felino","Lucifer", "15/12/2021", "", duenioTres.Name, duenioTres.Apellido, duenioTres.Domicilio, duenioTres.Telefono);
            Mascota mascotaCuatro = new Mascota("Canino", "Aquiles", "19/04/2019", "Contra  Rabia", duenioTres.Name, duenioTres.Apellido, duenioTres.Domicilio, duenioTres.Telefono);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(mascotaTres.Mostrar());

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(mascotaCuatro.Mostrar());

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}