using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aselsan.RadarDonanimTest.ObserverDesignPattern
{
    public class AnaFormKontrol : IObserver
    {
        public void Update()
        {
            Console.WriteLine("Ana Form Kontrol Güncellendi.");
        }

        public void Update(IObservable observable)
        {
            Console.WriteLine("Ana Form Kontrol Güncellendi::" + observable.DkkAkimDegeri);
        }
    }
}
