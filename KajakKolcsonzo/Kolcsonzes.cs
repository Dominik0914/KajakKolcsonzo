using System;
using System.Collections.Generic;
using System.Text;

namespace KajakKolcsonzo
{
    public class Kolcsonzes
    {
        public string BerlonNev { get; set; }
        public string HajoTipus { get; set; }
        public int BereltOrak { get; set; }
        public int MentoMellenyek { get; set; }
        public int KesesPerc { get; set; }


        public Kolcsonzes(string sor)
        {
            string[] var = sor.Split(";");
            BerlonNev = var[0];
            HajoTipus = var[1];
            BereltOrak = int.Parse(var[2]);
            MentoMellenyek = int.Parse(var[3]);
            KesesPerc = int.Parse(var[4]);
        }
        public int FizetendoOsszeg()
        {
            int oss = 0;
            if (HajoTipus == "KAJAK")
            {
                oss += 2500 * BereltOrak;
            }
            else if (HajoTipus == "KENU")
            {
                oss += 4000 * BereltOrak;
            }
            oss += (MentoMellenyek - 1) * 500;
            if (KesesPerc>=15)
            {
                oss += 3000;
            }
            return oss;
        }
        public override string ToString()
        {
            return $"{BerlonNev} ({HajoTipus}): {BereltOrak} óra, {MentoMellenyek} mentőmellény, {KesesPerc} perc késés - Fizetendő: {FizetendoOsszeg()} Ft";
        }
    }
}
