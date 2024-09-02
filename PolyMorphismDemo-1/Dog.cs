using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorphismDemo_1
{
    public abstract class DogBase
    {
        public string Name { get; set; }

        public DogBase(string name)
        { 
            this.Name = name; 
        }

        public abstract void Bark();
        

        public virtual void Pee()
        {
            Console.WriteLine($"{Name} is setting up to pee.");
        }

        public void JumpOnCouch()
        {
            Console.WriteLine($"There is now hair from {Name} all over the sofa.");
        }
    }

    public class MaleDog : DogBase
    {

        public MaleDog(string name) : base(name) { }

        public override void Bark()
        {
            Console.WriteLine("BARK!");
        }

        public override void Pee()
        {
            base.Pee();
            Console.WriteLine("Lift leg");
            Console.WriteLine("Aim at vertical object");
            Console.WriteLine("Let go.");
        }
    }

    public class FemaleDog : DogBase
    {
        public FemaleDog(string name) : base(name) { }

        public override void Pee()
        {
            base.Pee();
            Console.WriteLine("Squat");
            Console.WriteLine("Let go.");
        }

        public override void Bark()
        {
            Console.WriteLine("Yip!");
        }
    }
}
