using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    public class Salamander: Huisdier, IZwemmen, ILopen
    {
        public string Zwemmen()
        {
            return Naam + " zwemt";
        }

        public string Lopen()
        {
            return Naam + " loopt";
        }
    }
}
