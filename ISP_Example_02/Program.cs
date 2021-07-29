namespace ISP_Example_02
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var rubberDuck = new RubberDuck();
            rubberDuck.Display();
            rubberDuck.Speak();
            rubberDuck.Swim();

            var mallardDuck = new MallardDuck();
            mallardDuck.Display();
            mallardDuck.Speak();
            mallardDuck.Swim();
            mallardDuck.Fly();

            var pictureDuck = new PictureDuck();
            pictureDuck.Display();
        }
    }
}
