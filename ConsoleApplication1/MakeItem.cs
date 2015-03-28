using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderEntrySystem
{
    //
    // MakeItem interface
    //
    interface IMakeItemBehavior
    {
        void makeItem();
    }


    //
    // MakeItem concrete classes
    //
    //
    //
    // Make Ice Cream implementation
    //
    class MakeIceCream : IMakeItemBehavior
    {
        public void makeItem()
        {
            bool entry = true;
            IceCream iceCream = null;

            //
            // Ice Cream is selected by user
            //
            do
            {
                Console.Write("\nWhat kind of ice cream would you like (vanilla, strawberry, chocolate, exit): ");
                string line = Console.ReadLine();

                if (line == "exit")
                {
                    return;
                }
                if (line == "vanilla")
                {
                    iceCream = new Vanilla();
                    break;
                }
                if (line == "strawberry")
                {
                    iceCream = new Strawberry();
                    break;
                }
                if (line == "chocolate")
                {
                    iceCream = new Chocolate();
                    break;
                }
                else
                {
                    entry = false;
                }

            } while (!entry);


            // reset entry check
            entry = true;


            //
            // Condiment decorator is selected by user
            //
            do
            {
                Console.Write("\nWhat kind of topping would you like (sprinkles, granola, chocolate chips, exit): ");
                string topping = Console.ReadLine();

                if (topping == "exit")
                {
                    return;
                }
                if (topping == "sprinkles")
                {
                    iceCream = new Sprinkles(iceCream);
                    break;
                }
                if (topping == "granola")
                {
                    iceCream = new Granola(iceCream);
                    break;
                }
                if (topping == "chocolate chips")
                {
                    iceCream = new ChocolateChips(iceCream);
                    break;
                }
                else
                {
                    entry = false;
                }

            } while (!entry);

            Console.Write("\nYour " + iceCream.GetDescription() + " is ready, yum! That will be " + iceCream.Cost() + " please.\n\n");
        }
    }


    //
    // Make Pizza implementation
    //
    class MakePizza : IMakeItemBehavior
    {
        public void makeItem()
        {
            bool entry = true;
            PizzaType pizzaType= null;

            //
            // Pizza is selected by user
            //
            do
            {
                Console.Write("\nWhat kind of pizza would you like (ny, chicago, exit): ");
                string line = Console.ReadLine();

                if (line == "exit")
                {
                    return;
                }
                if (line == "ny")
                {
                    pizzaType = new NYPizza();
                    break;
                }
                if (line == "chicago")
                {
                    pizzaType = new ChicagoPizza();
                    break;
                }
                else
                {
                    entry = false;
                }

            } while (!entry);


            // reset entry check
            entry = true;

            //
            // Pizza topping is selected by user
            //
            do
            {
                Console.Write("\nWhat kind of pizza topping would you like (cheese, pepperoni, exit): ");
                string topping = Console.ReadLine();

                if (topping == "exit")
                {
                    return;
                }
                if (topping == "cheese")
                {
                    pizzaType.OrderPizza("cheese");
                    break;
                }
                if (topping == "pepperoni")
                {
                    pizzaType.OrderPizza("pepperoni");
                    break;
                }
                else
                {
                    entry = false;
                }

            } while (!entry);

            Console.Write("\nYour pizza is ready, yum! That will be 9.99 please.\n\n");
        }
    }


    //
    // Make beverage implementations
    //
    class MakeBeverage : IMakeItemBehavior
    {
        public void makeItem()
        {
            bool entry = true;
            Beverage beverage = null;

            //
            // Beverage is selected by user
            //
            do
            {
                Console.Write("\nWhat kind of beverage would you like (house blend, espresso, decaf, dark roast, exit): ");
                string line = Console.ReadLine();

                if (line == "exit")
                {
                    return;
                }
                if (line == "house blend")
                {
                    beverage = new HouseBlend();
                    break;
                }
                if (line == "espresso")
                {
                    beverage = new Espresso();
                    break;
                }
                if (line == "decaf")
                {
                    beverage = new Decaf();
                    break;
                }
                if (line == "dark roast")
                {
                    beverage = new DarkRoast();
                    break;
                }
                else
                {
                    entry = false;
                }

            }while( !entry );


            // reset entry check
            entry = true;


            //
            // Condiment decorator is selected by user
            //
            do
            {
                Console.Write("\nWhat kind of condiment would you like (mocha, soy, whip, exit): ");
                string condiment = Console.ReadLine();

                if (condiment == "exit")
                {
                    return;
                }
                if (condiment == "mocha")
                {
                    beverage = new Mocha(beverage);
                    break;
                }
                if (condiment == "soy")
                {
                    beverage = new Soy(beverage);
                    break;
                }
                if (condiment == "whip")
                {
                    beverage = new Whip(beverage);
                    break;
                }
                else
                {
                    entry = false;
                }

            } while (!entry);

            Console.Write("\nYour " + beverage.GetDescription() + " is ready, yum! That will be " + beverage.Cost() + " please.\n\n");
            
        }
    }
}
