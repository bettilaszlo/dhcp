using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dhcp
{
    class Program
    {
        static List<IP> excluded = new List<IP>();
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
        static void Main(string[] args)
        {
            BeolvasExcuded();

            foreach (var ex in excluded)
            {
                Console.WriteLine(ex.OK4);
            }


            Console.ReadKey();
        }
    }
}
