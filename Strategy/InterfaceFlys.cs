namespace Strategy
{
    public interface InterfaceFlys
    {
         string fly();
    }

    class itFlies : InterfaceFlys {
        public string fly() {
            return "Flying high!";
        }
    }

    class cantFly : InterfaceFlys {
        public string fly() {
            return "Unable to fly.";
        }
    }
}