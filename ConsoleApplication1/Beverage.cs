using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderEntrySystem
{
    //
    // Beverage abstract class
    //
    abstract class Beverage
    {
        public virtual string GetDescription()
        {
            return "Unknown Beverage";
        }

        public abstract double Cost();
    }


    //
    // Beverage Concrete classes
    //

    //
    // House blend class implementation
    //
    class HouseBlend : Beverage
    {
        public HouseBlend() { }

        public override double Cost() { return .89; }

        public override string GetDescription()
        {
            return "House Blend Coffee";
        }
    }


    //
    // Espresso class implementation
    //
    class Espresso : Beverage
    {
        public Espresso() { }

        public override double Cost() { return 1.99; }

        public override string GetDescription()
        {
            return "Espresso";
        }
    }


    //
    // Decaf class implementation
    //
    class Decaf : Beverage
    {
        public Decaf() { }

        public override double Cost() { return 1.99; }

        public override string GetDescription()
        {
            return "Decaf Coffee";
        }
    }


    //
    // Dark Roast class implementation
    //
    class DarkRoast : Beverage
    {
        public DarkRoast() { }

        public override double Cost() { return 1.99; }

        public override string GetDescription()
        {
            return "Dark Roast Coffee";
        }
    }



    //
    //
    // CondimentDecorator abstract class
    //
    //
    abstract class CondimentDecorator : Beverage
    {
        public CondimentDecorator() { }
    }


    //
    // CondimentDecorator concrete classes
    //

    //
    // Mocha class implementation
    //
    class Mocha : CondimentDecorator
    {
        Beverage beverage;

        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double Cost()
        {
            return .20 + beverage.Cost();
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + " Mocha";
        }
    }


    //
    // Soy class implementation
    //
    class Soy : CondimentDecorator
    {
        Beverage beverage;

        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double Cost()
        {
            return .20 + beverage.Cost();
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + " Soy";
        }
    }


    //
    // Whip class implementation
    //
    class Whip : CondimentDecorator
    {
        Beverage beverage;

        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double Cost()
        {
            return .20 + beverage.Cost();
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + " Whip";
        }
    } 


}
