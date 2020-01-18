using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal woofy = new Dog();
            Animal tweety = new Bird();

            Console.WriteLine("Dog: " + woofy.tryToFly());
            Console.WriteLine("Bird: " + tweety.tryToFly());

            woofy.setFlyingAbility(new itFlies());
            Console.WriteLine("Dog: " + woofy.tryToFly());
        }
    }
}
