using System;

namespace secao14_interfaces.Device
{
    internal class ComboDevice : Device, IScanner, IPrinter
    {
        public void Print(string document)
        {
            Console.WriteLine("Combo Device print " + document);
        }

        public override void ProcessDoc(string doc)
        {
            Console.WriteLine("Combo device processing " + doc);
        }

        public string Scan()
        {
            return "Combo device result ";
        }
    }
}
