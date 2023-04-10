using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    internal class Cuenta
    {
        private string titular;
        private int cuenta;

        public Cuenta(string titular, int cuenta)
        {
            this.titular = titular;
            this.cuenta = cuenta;
        }


        public string GetTitular() 
        { 
            return titular; 
        }

        public int GetCuenta()
        {
            return cuenta;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("====================");
            sb.AppendLine($"Titular de la cuenta: {titular}");
            sb.AppendLine($"Cantidad actual: {cuenta}");
            sb.AppendLine("====================");
            return sb.ToString();
            
        }

        public void Ingresar(int cuenta) 
        {
            if (cuenta > 0)
            {
            this.cuenta += cuenta;
            }
        }

        public void Retirar(int cuenta)
        {
            this.cuenta -= cuenta;
        }


    }
}
