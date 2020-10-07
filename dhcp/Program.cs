using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dhcp
{
    class Program
    {
        static void Main(string[] args)
        {
            var ip = new IP("192.168.10.100");

            Console.WriteLine(ip.IPSzoveg);
            Console.WriteLine(ip.CimPluszEgy());


            Console.ReadKey();
        }
    }
}
