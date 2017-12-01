using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    public class Hond: Huisdier, ILopen
    {
        public string Blaffen()
        {
            return Naam + " blaft";
        }

        public string Lopen()
        {
            return Naam + " loopt";
        }
    }
}
