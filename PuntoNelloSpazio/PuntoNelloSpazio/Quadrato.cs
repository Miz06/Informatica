using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoNelloSpazio
{
    internal class Quadrato : Rettangolo
    {
        public Quadrato(PosizioneAngolo p, int _altezza, int _larghezza) : base(p, _altezza, _larghezza)
        {
        }

        public Quadrato(int x, int y, int _altezza, int _larghezza) : base(x, y, _altezza, _larghezza)
        {
        }
    }
}
