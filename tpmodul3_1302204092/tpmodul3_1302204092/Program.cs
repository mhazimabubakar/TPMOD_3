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

            Console.WriteLine("Kode Pos: " + kp1.getKodePos(inputKelurahan));

            Console.WriteLine();

            DoorMachine objDoorMach = new DoorMachine();
            Console.WriteLine("Keadaan awal pintu: " + objDoorMach.StateSaatIni);
            Console.WriteLine();

            objDoorMach.AksiYangDilakukan(DoorMachine.Aksi.KunciPintu);
            Console.WriteLine();
            objDoorMach.AksiYangDilakukan(DoorMachine.Aksi.BukaPintu);
            Console.WriteLine();
        }
    }
}
