using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aselsan.RadarDonanimTest.ObserverDesignPattern
{
    public interface IObserver
    {
        void Update();
        void Update(IObservable observable);
    }
}
