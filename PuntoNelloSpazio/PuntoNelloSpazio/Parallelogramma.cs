using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoNelloSpazio
{
    internal class Parallelogramma:Rettangolo
    {
        int volume;

        public Parallelogramma(PosizioneAngolo p, int _altezza, int _larghezza, int _volume) : base(p, _altezza, _larghezza)
        {
            volume = _volume;
        }

        public Parallelogramma(int x, int y, int _altezza, int _larghezza, int _volume) : base(x, y, _altezza, _larghezza)
        {
            volume = _volume;
        }

        public int Volume()
        {
            return GetAltezza * GetLarghezza * volume;
        }
    }
}
