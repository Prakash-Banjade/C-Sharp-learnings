using System;

namespace MethodOverridingVsHiding {
    class Base {
        public virtual void Display() {
            Console.WriteLine("This is from Base class");
        }
    }

    class OverridingClass: Base {
        public override void Display() {
            Console.WriteLine("This is from OverridingClass");
        }
    }

    class HidingClass: Base {
        public new void Display(){
            Console.WriteLine("This is from HidingClass");
        }
    }

    class Program {
        static void Main() {
            // creating base class reference instances
            Base baseObj = new Base();
            Base overridingObj = new OverridingClass(); // base class Display() method is overriden by OverridingClass
            Base hidingObj = new HidingClass(); // base class Display() method remains intact

            // calling Display() method on each
            baseObj.Display();
            overridingObj.Display();
            hidingObj.Display();
        }
    }
}