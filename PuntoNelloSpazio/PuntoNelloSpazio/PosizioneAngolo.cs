using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoNelloSpazio
{
    internal class PosizioneAngolo
    {
        int x, y;

        public PosizioneAngolo()//default
        {
            x = 0;
            y = 0;
        }

        public PosizioneAngolo(int _x, int _y)//inserimento
        {
            x = _x;
            y = _y;
        }

        public int GetYPoint
        {
            get { return y; }
        }

        public int GetXPoint
        {
            get { return x; }
        }
    }
}
