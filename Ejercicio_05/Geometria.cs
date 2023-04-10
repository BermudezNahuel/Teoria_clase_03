using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    internal class Punto
    {
        private int _x;
        private int _y;

        public int GetX() { return _x; }
        public int GetY() { return _y;}

        public Punto(int x, int y)
        {
            _x = x;
            _y = y;
        }

    }

    internal class Rectangulo
    {

        
        private float _area;
        private float _perimetro;
        private Punto _vertice1;
        private Punto _vertice2;
        private Punto _vertice3;
        private Punto _vertice4;

       

        public float GetArea { get => _area; }

        public float GetPerimetro { get => _perimetro; }
        
        
        
        public Rectangulo(Punto vertice1, Punto vertice2, Punto vertice3, Punto vertice4)
        {
            _vertice1 = vertice1;
            _vertice2 = vertice2;
            _vertice3 = vertice3;
            _vertice4 = vertice4;
        }

        private float CalcularBaseRectangulo()
        {
            float base_rectangulo = Math.Abs(_vertice2.GetX() - _vertice1.GetX());
            return base_rectangulo;
        }

        private float CalcularAlturaRectangulo()
        {
            float altura_rectangulo = Math.Abs(_vertice2.GetY() - _vertice3.GetY());
            return altura_rectangulo;
        }


        public float Area()
        {
            _area = CalcularAlturaRectangulo() * CalcularBaseRectangulo();

            return _area;
        }

        
        public float Perimetro()
        {
            _perimetro = (CalcularBaseRectangulo() + CalcularAlturaRectangulo()) * 2;

            return _perimetro;
        }

        
    
        
    
    
    
    
    }
}
