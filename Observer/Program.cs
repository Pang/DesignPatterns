using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            StockGrabber stockGrabber = new StockGrabber();

            StockObserver observer1 = new StockObserver(stockGrabber);

            stockGrabber.setStockPrice(123.12);
        }
    }
}
