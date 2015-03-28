using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderEntrySystem
{
    //
    // IceCream abstract class
    //
    abstract class IceCream
    {
        public virtual string GetDescription()
        {
            return "Unknown IceCream";
        }

        public abstract double Cost();
    }


    //
    // IceCream Concrete classes
    //

    //
    // Vanilla implementation
    //
    class Vanilla : IceCream
    {
        public Vanilla() { }

        public override double Cost() { return 2.99; }

        public override string GetDescription()
        {
            return "Vanilla";
        }
    }


    //
    // Strawberry implementation
    //
    class Strawberry : IceCream
    {
        public Strawberry() { }

        public override double Cost() { return 2.99; }

        public override string GetDescription()
        {
            return "Strawberry";
        }
    }


    //
    // Chocolate implementation
    //
    class Chocolate : IceCream
    {
        public Chocolate() { }

        public override double Cost() { return 2.99; }

        public override string GetDescription()
        {
            return "Chocolate";
        }
    }



    //
    //
    // Toppings abstract class
    //
    //
    abstract class Toppings : IceCream
    {
        public Toppings() { }
    }


    //
    // Toppings concrete classes
    //

    //
    // Sprinkles class implementation
    //
    class Sprinkles : Toppings
    {
        IceCream iceCream;

        public Sprinkles(IceCream iceCream)
        {
            this.iceCream = iceCream;
        }

        public override double Cost()
        {
            return .25 + iceCream.Cost();
        }

        public override string GetDescription()
        {
            return iceCream.GetDescription() + " Sprinkles";
        }
    }


    //
    // Granola class implementation
    //
    class Granola : Toppings
    {
        IceCream iceCream;

        public Granola(IceCream iceCream)
        {
            this.iceCream = iceCream;
        }

        public override double Cost()
        {
            return .25 + iceCream.Cost();
        }

        public override string GetDescription()
        {
            return iceCream.GetDescription() + " Granola";
        }
    }


    //
    // Chocolate Chips class implementation
    //
    class ChocolateChips : Toppings
    {
        IceCream iceCream;

        public ChocolateChips(IceCream iceCream)
        {
            this.iceCream = iceCream;
        }

        public override double Cost()
        {
            return .25 + iceCream.Cost();
        }

        public override string GetDescription()
        {
            return iceCream.GetDescription() + " Chocolate Chips";
        }
    } 

}
