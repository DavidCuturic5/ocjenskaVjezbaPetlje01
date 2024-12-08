using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ocjenskaVjezba1.PolugodistePetlje01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int godina = 1900; godina <= 2100; godina++)
            {
                if ((godina % 400 == 0) || (godina % 4 == 0 && godina % 100 != 0)) {
                    Console.WriteLine(godina);
                }
            }

            Console.ReadKey();

        }
    }
}
