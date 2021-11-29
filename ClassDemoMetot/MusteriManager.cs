using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemoMetot
{
    class MusteriManager
    {
        public void MusteriAdd(Musteri musteri)
        {
            Console.WriteLine("Müşteri adı : " + musteri.Adi + " " + "Müşteri Soyadı : " + musteri.Soyad + " " + " Telefon Numarası : " + musteri.TelNo + "müşteri eklenmiştir.");
        }

        public void MusteriDel(Musteri musteri)
        {
            Console.WriteLine("Müşteri adı : " + musteri.Adi + " " + "Müşteri Soyadı : " + musteri.Soyad + " " + " Telefon Numarası : " + musteri.TelNo + " müşteri silinmiştir.");
        }

        public void MusteriList(Musteri musteri)
        {
            Console.WriteLine("Müşteri adı : " + musteri.Adi + " " + "Müşteri Soyadı : " + musteri.Soyad + " " + " Telefon Numarası : " + musteri.TelNo + "müşteri listelenmiştir.");
        }
    }
}
