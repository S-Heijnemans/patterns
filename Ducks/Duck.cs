using StrategyPattern.Interfaces.FlyBehavior;
using StrategyPattern.Interfaces.QuackBehavior;
using StrategyPattern.Interfaces.SwimBehavoir;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Ducks
{
    internal abstract class Duck
    {
        protected QuackBehavior quackBehavior;

        protected FlyBehavior flyBehavior;

        protected SwimBehavior swimBehavior;

        public abstract void Display();

        public void SetQuackBehavior(QuackBehavior quack)
        {
            quackBehavior = quack;
        }

        public void SetFlyBehavior(FlyBehavior fly)
        {
            flyBehavior = fly;
        }

        public void SetSwimBehavior(SwimBehavior swim)
        {
            swimBehavior = swim;
        }

        public void PerformQuack()

        {

            quackBehavior.Quack();

        }

        public void PerformFly()

        {

            flyBehavior.Fly();

        }

        public void PerformSwim()
        {
            swimBehavior.Swim();
        }
    }
}
