using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul3_1302204092
{
    public class Program
    {
        static void Main(string[] args)
        {
            KodePos kp1 = new KodePos();

            KodePos.Kelurahan inputKelurahan = KodePos.Kelurahan.Kujangsari;

            Console.WriteLine(kp1.getKodePos(inputKelurahan));
        }
    }
}
