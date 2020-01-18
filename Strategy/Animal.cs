namespace Strategy
{
    public class Animal
    {
        public InterfaceFlys flyingType;

        public void setFlyingAbility(InterfaceFlys newFlyType)
        {
            flyingType = newFlyType;
        }
    
        public string tryToFly() 
        {
            return flyingType.fly();
        }
    }
}