using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aselsan.RadarDonanimTest.ObserverDesignPattern
{
    public class DcGucTestleriKontrol : IObserver
    {
        public void Update()
        {
            Console.WriteLine("DC Güç Testleri Kontrol Güncellendi.");
        }

        public void Update(IObservable observable)
        {
            Console.WriteLine("DC Güç Testleri Kontrol Güncellendi::" + observable.DkkAkimDegeri);
        }
    }
}
