using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Piano : Instrument
    {
        public int NumKeys { get; set; }
        public string Categorie { get; set; } //Three types of categories: Grand pianos, Upright pianos and digital pianos.
    }
}