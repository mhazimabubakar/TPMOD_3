using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul3_1302204092
{
    public class DoorMachine
    {
        public enum Status
        {
            Terkunci,
            Terbuka
        };

        public enum Aksi
        {
            BukaPintu,
            KunciPintu
        };

        public class Transisi
        {
            public Status StateAwal;
            public Status StateAkhir;
            public Aksi Trigger;

            public Transisi(Status awal, Status akhir, Aksi yangDilakukan)
            {
                StateAwal = awal;
                StateAkhir = akhir;
                Trigger = yangDilakukan;
            }
        }
        Transisi[] listPerpindahanState =
            {
            new Transisi(Status.Terkunci, Status.Terbuka, Aksi.BukaPintu),
            new Transisi(Status.Terbuka, Status.Terkunci, Aksi.KunciPintu),
        };

        public Status StateSaatIni = Status.Terkunci;

        public Status GetStatusAkhir(Status awal, Aksi yangDilakukan)
        {
            Status statusAkhir = awal;

            for (int i = 0; i < listPerpindahanState.Length; i++)
            {
                Status stateAwal = listPerpindahanState[i].StateAwal;
                Aksi triggerState = listPerpindahanState[i].Trigger;

                if (stateAwal == awal && triggerState == yangDilakukan)
                {
                    statusAkhir = listPerpindahanState[i].StateAkhir;
                }
            }

            return statusAkhir;
        }

        public void AksiYangDilakukan(Aksi yangDilakukan)
        {
            Status stateBerikutnya = GetStatusAkhir(StateSaatIni, yangDilakukan);
            StateSaatIni = stateBerikutnya;

            Console.WriteLine("Situasi saat ini: " + StateSaatIni);

            if (StateSaatIni == Status.Terkunci)
            {
                Console.WriteLine("Pintu terkunci");
            }
            else
            {
                Console.WriteLine("Pintu tidak terkunci");
            }
        }

        public DoorMachine()
        {
            StateSaatIni = Status.Terkunci;
        }
    }
}
