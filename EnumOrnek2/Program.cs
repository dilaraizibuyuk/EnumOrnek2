using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumOrnek2
{
    class Program
    {
        public enum KonutTuru
        {
            Belirsiz,
            Apart,
            Apartman,
            Residence,
            Villa
        }
        public class Ev
        {
            public KonutTuru ozellik;

            public Ev()
            {
                ozellik = KonutTuru.Belirsiz;
            }

            public void Goruntule()
            {
                Console.WriteLine("Konut Türü: {0}", ozellik);
            }
        }
        static void Main(string[] args)
        {
            Ev bicim = new Ev();
            bicim.Goruntule();
            bicim.ozellik = KonutTuru.Villa;
            bicim.Goruntule();
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
