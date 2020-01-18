namespace Strategy
{
    public class Dog : Animal
    {
        public Dog()
        {
            flyingType = new cantFly();
        }
    }
}