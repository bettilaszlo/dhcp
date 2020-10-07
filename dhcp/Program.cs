using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace dhcp
{
    class Program
    {
        static List<IP> excluded = new List<IP>();
        static Dictionary<string, IP> reserved = new Dictionary<string, IP>();
        static Dictionary<string, IP> dhcp = new Dictionary<string, IP>();
        static void BeolvasExcuded()
        {
            try
            {
                StreamReader file = new StreamReader("excluded.csv");

                while (!file.EndOfStream)
                {
                    excluded.Add(new IP(file.ReadLine()));
                }
               
                file.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void BeolvasDictionary(Dictionary<string, IP> d, string filenev)
        {
            try
            {
                StreamReader file = new StreamReader(filenev);
                
                while (!file.EndOfStream)
                {
                    string[] adat = file.ReadLine().Split(';');
                    d.Add(adat[0], new IP(adat[1]));
                }

                file.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        static void Main(string[] args)
        {
            BeolvasExcuded();
            BeolvasDictionary(reserved, "reserved.csv");
            BeolvasDictionary(dhcp, "dhcp.csv");
            foreach (var r in dhcp)
            {
                Console.WriteLine(r.Key+"--->"+r.Value.IPSzoveg);
            }

            Console.ReadKey();
        }
    }
}
