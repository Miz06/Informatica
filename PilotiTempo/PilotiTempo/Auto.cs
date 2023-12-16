using PilotiTempo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace PilotiTempo
{
    internal class Auto
    {
        private static readonly Random r = new Random();
        string scuderia;
        TimeSpan tempo;
        Pilota pilot;

        public Auto(string _scuderia, Pilota _pilot)
        {
            scuderia = _scuderia;
            pilot = _pilot;
            tempo = Genera(r);
        }

        public override string ToString()
        {
            return String.Format($"scuderia: {scuderia}, {pilot.ToString()}, tempo: {tempo}");
        }

        public TimeSpan Genera(Random r)
        {
            TimeSpan tempo;
            int hours, minutes, seconds;
            
            hours = r.Next(0, 3);
            minutes = r.Next(0, 60);
            seconds = r.Next(0,60);

            tempo = new TimeSpan(hours, minutes, seconds);
            return tempo;
        }

        public TimeSpan TimeSpanR(Auto e)
        {
            return e.tempo;
        }
    }
}
