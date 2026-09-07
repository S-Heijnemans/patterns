using StrategyPattern.Ducks;
using StrategyPattern.Interfaces.FlyBehavior;

namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duck mallardDuck = new MallardDuck();
            Duck redheadDuck = new RedheadDuck();
            Duck decoyDuck = new DecoyDuck();
            Duck rubberDuck = new RubberDuck();
            Duck robotDuck = new RobotDuck();

            mallardDuck.PerformQuack();
            mallardDuck.PerformFly();
            mallardDuck.PerformSwim();

            redheadDuck.PerformQuack();
            redheadDuck.PerformFly();

            decoyDuck.PerformQuack();
            decoyDuck.PerformFly();

            rubberDuck.PerformQuack();
            rubberDuck.PerformFly();

            robotDuck.PerformSwim();
            robotDuck.SetFlyBehavior(new FlyWithWings());
            robotDuck.PerformFly(); 
        }
    }
}