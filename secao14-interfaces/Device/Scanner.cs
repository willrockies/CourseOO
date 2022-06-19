using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secao14_interfaces.Device
{
    internal class Scanner : Device, IScanner
    {
        public override void ProcessDoc(string doc)
        {
            Console.WriteLine("Scanner processing: " + doc);
        }
        public string Scan()
        {
            return "Scanner scan result";
        }

    }
}
