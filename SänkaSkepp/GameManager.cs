using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SänkaSkepp
{
    //Observer pattern
    public class GameManager
    {
        private List<IGameObserver> _observers;

        public GameManager()
        {
            _observers = new List<IGameObserver>();
        }
        public void AttachObserver(IGameObserver observer)
        {
            _observers.Add(observer);
        }
        public void DetachObserver(IGameObserver observer)
        {
            _observers.Remove(observer);
        }
        public void NotifyObservers(string message)
        {
            foreach (var observer in _observers)
            {
                observer.Update(message);
            }
        }
        public void PlayGame()
        {
            NotifyObservers("Game has started");
        }
          
    }
}
