namespace Observer
{
    public class StockObserver : Observer
    {
        private double stockPrice;
        private static int observerIDTracker = 0;
        private int observerID;
        private Subject stockGrabber;
        public StockObserver(Subject stockGrabber) {
            this.stockGrabber = stockGrabber;
            this.observerID = ++observerIDTracker;
            System.Console.WriteLine("Observer " + this.observerID + " is now subscribed to Stocks.");
            stockGrabber.register(this);
        }

        public void update(double stockPrice) {
            this.stockPrice = stockPrice;
            printStocks();
        }

        public void printStocks() {
            System.Console.WriteLine("Observer " + observerID + " returns:\nStock: " + stockPrice);
        }
    }
}