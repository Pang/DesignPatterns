using System.Collections;
using System.Collections.Generic;

namespace Observer
{
    public class StockGrabber : Subject
    {
        ArrayList observers = new ArrayList();
        private double stockPrice;

        public StockGrabber() {
            
        }
        public void register(Observer newObserver) {
            observers.Add(newObserver);        }
        public void unregister(Observer deleteObserver) {
            int observerIndex = observers.IndexOf(deleteObserver);
            System.Console.WriteLine("Observer: " + (observerIndex + 1));
            observers.RemoveAt(observerIndex);
        }
        public void notifyObserver() {
            foreach(Observer observer in observers) {
                observer.update(stockPrice);
            }
        }
        public void setStockPrice(double newStockPrice) {
            this.stockPrice = newStockPrice;
            notifyObserver();
        }
    }
}