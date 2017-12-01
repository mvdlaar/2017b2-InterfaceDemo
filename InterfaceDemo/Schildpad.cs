using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class Schildpad: Huisdier, IZwemmen
    {
        public string Zwemmen()
        {
            return Naam + " zwemt";
        }
    }
}
