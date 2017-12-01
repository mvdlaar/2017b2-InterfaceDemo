using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    public abstract class Huisdier
    {
        public string Naam;

        public string Eten()
        {
            return Naam + " eet";
        }
    }
}
