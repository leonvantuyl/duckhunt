using Hunter_DesignPatternsGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hunter_DesignPatterns.Model.Provider
{
    //TODO possibly remove this class
    public class UnitMonitor : IObservable<UnitBase>
    {
        List<IObserver<UnitBase>> observers;

        public UnitMonitor()
        {
            observers = new List<IObserver<UnitBase>>();
        }

        private class Unsubscriber : IDisposable
        {
            private List<IObserver<UnitBase>> _observers;
            private IObserver<UnitBase> _observer;

            public Unsubscriber(List<IObserver<UnitBase>> observers, IObserver<UnitBase> observer)
            {
                this._observers = observers;
                this._observer = observer;
            }

            public void Dispose()
            {
                if (!(_observer == null)) _observers.Remove(_observer);
            }
        }

        public IDisposable Subscribe(IObserver<UnitBase> observer)
        {
            if (!observers.Contains(observer))
                observers.Add(observer);

            return new Unsubscriber(observers, observer);
        }
    }
}
