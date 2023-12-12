using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piloti
{
    internal class Auto
    {

        string scuderia;
        Pilota pilot;

        public Auto(string _scuderia, Pilota _pilot)
        {
            scuderia = _scuderia;
            pilot = _pilot;
        }

        public override string ToString()
        {
            return  String.Format($"scuderia: {scuderia}, {pilot.ToString()}");
        }
    }
}
