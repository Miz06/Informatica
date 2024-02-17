using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoNelloSpazio
{
    internal class Rettangolo
    {
        int altezza, larghezza;
        
        public Rettangolo(PosizioneAngolo p, int _altezza, int _larghezza)
        {
            altezza = _altezza;
            larghezza = _larghezza;
        }

        public Rettangolo(int x, int y, int _altezza, int _larghezza):this(null, _altezza, _larghezza)
        {
        }

        public int Area()
        {
            return altezza*larghezza;
        }

        public int Perimetro()
        {
            return (altezza +larghezza)*2;
        }
        public int GetAltezza
        {
            get { return altezza; }
        }

        public int GetLarghezza
        {
            get { return larghezza; }
        }
    }
}
