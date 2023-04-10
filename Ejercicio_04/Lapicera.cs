using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04
{
    internal class Lapicera
    {
        private const int _CantidadTintaMaxima = 100;
        private ConsoleColor _color;
        private int _tinta;

        public Lapicera(ConsoleColor color, int tinta)
        {
            _color = color;
            _tinta = tinta;
        }

        public ConsoleColor Color 
        {
            get => _color;
        }

        public int Tinta
        {
            get => _tinta;
        }


        private void SetTinta(int tinta)
        {   
            int total = _tinta + tinta;
            if (total >= 0 || total <= _CantidadTintaMaxima) 
            {
                _tinta = total;
            }
        }


        public void Recargar()
        {
            _tinta = _CantidadTintaMaxima;
        }

        public string Pintar(int gasto)
        {

            string dibujo = "";
            
            SetTinta(gasto);

            if (_tinta > 0)
            {
                for (int i = 0; i < gasto; i++)
                {
                    dibujo += "*";
                }
            }

            return dibujo;
        }



    }
}
