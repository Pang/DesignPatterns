namespace Observer
{
    public class StockGrabber : Subject
    {
        private ArrayList<Observer> observers;
        private double stockPrice;

        public StockGrabber(){
            observers = new ArrayList<Observer>();
        }
        public void register(Observer newObserver) {
            observers.add(newObserver);        }
        public void unregister(Observer deleteObserver) {
            int observerIndex = observers.IndexOf(deleteObserver);
            System.Console.WriteLine("Observer: " + (observerIndex + 1));
            observers.splice(observerIndex);
        }
        public void notifyObserver() {
            foreach(Observer observer in observers) {
                observer.update(stockprice);
            }
        }
        public void setStockPrice() {
            this.stockPrice = newStockPrice;
            notifyObserver();
        }
    }
}