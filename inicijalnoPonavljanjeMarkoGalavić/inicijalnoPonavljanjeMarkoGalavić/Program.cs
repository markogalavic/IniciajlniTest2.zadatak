using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inicijalnoPonavljanjeMarkoGalavić
{
    class Program
    {
        static void Main(string[] args)
        {
            float secs=0;
            float mnt = 0;
            Console.WriteLine("Unesi broj sekundi");
            secs = Int32.Parse(Console.ReadLine());

            mnt = secs / 60;

            Console.WriteLine(mnt + "minuta");
            Console.ReadKey();
        }
    }
}
