using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoNelloSpazio
{
    internal class Rettangolo
    {
        int height, width;
        
        public Rettangolo(PosizioneAngolo p)
        {
            height = p.y;
            width = p.x;
        }

        public Rettangolo(int x, int y)
        {
            height = y;
            width = x;
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
