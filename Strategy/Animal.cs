namespace Strategy
{
    public class Animal
    {
        public InterfaceFlys flyingType;

        public string tryToFly() 
        {
            return flyingType.fly();
        }

        public void setFlyingAbility(InterfaceFlys newFlyType)
        {
            flyingType = newFlyType;
        }
    }
}