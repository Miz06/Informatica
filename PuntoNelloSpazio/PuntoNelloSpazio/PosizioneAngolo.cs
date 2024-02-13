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

        public PosizioneAngolo()
        {
            x = GeneraNumeri(0, 101);
            y = GeneraNumeri(0, 21);
        }

        public int GeneraNumeri(int estremo1, int etremo2)
        {
            Random r = new Random();

            return r.Next(estremo1, etremo2);
        }

        public int GetHeightPoint
        {
            get { return y; }
            set { y = value; }
        }

        public int GetWidthPoint
        {
            get { return x; }
            set { x = value; }
        }
    }
}
