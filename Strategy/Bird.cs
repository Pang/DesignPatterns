namespace Strategy
{
    public class Bird : Animal
    {
        public Bird() 
        {
            flyingType = new itFlies();
        }
    }
}