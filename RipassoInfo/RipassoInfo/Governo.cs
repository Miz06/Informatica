﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RipassoInfo
{
    internal class Governo
    {
        string t;
        public string targa
        {
            get { return t; }
            set { t = value; }
        }
        public string GeneraTarga()
        {
            Random random = new Random();
            int r;
            string targa = "";

            for (int i = 0; i < 2; i++)
            {
                r = random.Next(65, 91);
                targa += Convert.ToChar(r);
            }

            r = random.Next(100, 1000);
            targa += Convert.ToString(r);

            for (int j = 0; j < 2; j++)
            {
                r = random.Next(65, 91);
                targa += Convert.ToChar(r);
            }

            return targa;
        }

    }
}
