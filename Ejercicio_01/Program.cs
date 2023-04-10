namespace Ejercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta_1 = new Cuenta("Juan Carlos", 1000);

            Console.WriteLine(cuenta_1.Mostrar());

            cuenta_1.Ingresar(-500);
            Console.WriteLine(cuenta_1.Mostrar());


            cuenta_1.Ingresar(2000);
            Console.WriteLine(cuenta_1.Mostrar());


            cuenta_1.Retirar(5000);
            Console.WriteLine(cuenta_1.Mostrar());

        }
    }
}