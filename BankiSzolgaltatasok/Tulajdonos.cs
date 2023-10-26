﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankiSzolgaltatasok
{
    public sealed class Tulajdonos
    {
        private string nev;
        public Tulajdonos(string nev)
        {
            this.nev = nev;
        }

        public string Nev { get => nev; set => nev = value; }
    }
}
