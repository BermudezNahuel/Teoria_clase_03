using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_A01
{
    internal class Conductor
    {
        private string _name;
        private int[] _kilometros;
        
        public int Kilometros(int i) 
        { 
            return _kilometros[i];
        }

        public string Name { get => _name; }

        public Conductor(string name, int diaUno, int diaDos, int diaTres, int diaCuatro, int diaCinco, int diaSeis, int diaSiete)
        {
            _name = name;
            _kilometros = new int[7];
            _kilometros[0] = diaUno;
            _kilometros[1] = diaDos;
            _kilometros[2] = diaTres;
            _kilometros[3] = diaCuatro;
            _kilometros[4] = diaCinco;
            _kilometros[5] = diaSeis;
            _kilometros[6] = diaSiete;
        }

        /// <summary>
        /// Recorrer un array y sumar todos sus elementos, y retorna la suma total
        /// </summary>
        /// <returns></returns>
        public int KilometrosPorSemana()
        {
            int sumaTotal = 0;
            foreach (int i in _kilometros) 
            {
                sumaTotal += i;
            }
                return sumaTotal;
        }



    }
}
