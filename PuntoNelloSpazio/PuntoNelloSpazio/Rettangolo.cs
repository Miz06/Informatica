using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoNelloSpazio
{
    struct Punto
    {
        public int x;
        public int y;
    }

    internal class Rettangolo
    {
        int height, width;
        
        public Rettangolo(Punto p)
        {
            height = 12;
            width = 20;
        }

        public Rettangolo(int x, int y)
        {
            height = 12;
            width = 20;
        }

        public int Area()
        {
            return height*width;
        }

        public int Perimetro()
        {
            return (height+width)*2;
        }
        public int GetHeight
        {
            get { return height; }
        }

        public int GetWidth
        {
            get { return width; }
        }
    }
}
