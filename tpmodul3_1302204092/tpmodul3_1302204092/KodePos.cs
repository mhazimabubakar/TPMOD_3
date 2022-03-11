using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul3_1302204092
{
    public class KodePos
    {
        public enum Kelurahan { Batununggal, Kujangsari, Mengger, Wates, Cijaura, Jatisari, 
            Margasari, Sekejati, Kebonwaru, Maleer, Samoja };

        public int getKodePos(Kelurahan inputKelurahan)
        {
            int[] arrayKodePos = { 40266, 40287, 40267, 40256, 40287, 40286, 40286, 40286, 40272, 40274, 40273 };

            return arrayKodePos[ (int)inputKelurahan ];
        }

    }
}
