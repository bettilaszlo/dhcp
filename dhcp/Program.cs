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
        static void BeolvasReserved()
        {
            try
            {
                StreamReader file = new StreamReader("reserved.csv");
                
                while (!file.EndOfStream)
                {
                    string[] adat = file.ReadLine().Split(';');
                    reserved.Add(adat[0], new IP(adat[1]));
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
            BeolvasReserved();
            foreach (var r in reserved)
            {
                Console.WriteLine(r.Key+"--->"+r.Value.IPSzoveg);
            }

            Console.ReadKey();
        }
    }
}
