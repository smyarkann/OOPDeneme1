using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDeneme
{
    internal class clsOzellik
    {
        public string Ad { get; set; }  
        public string Soyad { get; set; }
        public int Boy { get; set; }
        public int Kilo { get; set; }
        public int Yas{ get; set; }

        public clsOzellik(int boy,int kilo,int yas, string ad,string soyad)

        {
            Soyad = soyad;
            Ad = ad;
            Boy = boy;
            Kilo = kilo;
            Yas= yas;


            Console.WriteLine(" Adınız: "+Ad+" Soyadınız: "+Soyad+ "\n Boyunuz: " + Boy + " Kilonuz: " + kilo + " Yaşınız: " + Yas );
        }
    }
}
