using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aselsan.RadarDonanimTest.ObserverDesignPattern
{
    public class DcGucTestTestleriModel : IObservable
    {
        List<IObserver> observers = new List<IObserver>();
        public void AddObserver(IObserver observer)
        {
            this.observers.Add(observer);
        }

        public void NotifyObservers()
        {
            foreach (IObserver o in this.observers)
                o.Update(this);
        }

        public void RemoveObserver(IObserver observer)
        {
            this.observers.Remove(observer);
        }
        double dcCurrent;
        double previousValue;
        double dkkCurrent;
        Random random;
        public void DcGucTestlerineBasla()
        {
            random = new Random();
            /* if (this.dcCurrent != this.dkkCurrent)
            {
                this.dcCurrent = this.dkkCurrent;
                this.NotifyObservers();
                Thread.Sleep(250);
            }*/
            this.DkkAkimDegeri = random.Next(2, 5) / 1.278;
        }
        public double DkkAkimDegeri
        {
            get
            {
                return this.dkkCurrent;
            }
            set
            {
                if (this.dkkCurrent != value)
                {
                    this.dkkCurrent = value;
                    this.NotifyObservers();
                    Thread.Sleep(250);
                }
                else
                    Console.WriteLine("Aynı değer olduğundan güncelleme isteği gönderilmedi");
            }
        }
    }
}