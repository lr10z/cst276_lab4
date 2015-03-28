using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace OrderEntrySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            // Loops through user order prompt
            //
            while (true)
            {
                Console.Write("Place a new order (pizza, ice cream, beverage, exit): ");
                string line = Console.ReadLine();

                if (line == "exit")
                {
                    break;
                }
                if (line == "pizza")
                {
                    PizzaMaker pm = new PizzaMaker();

                    if( pm.NumPizzas < 0)
                    {
                        pm.soldOut();
                        continue;
                    }

                    pm.greet();
                    pm.makeItem();
                    pm.notifyObservers();
                }
                if (line == "ice cream")
                {
                    IceCreamMaker icm = new IceCreamMaker();

                    if (icm.NumIceCreams < 0)
                    {
                        icm.soldOut();
                        continue;
                    }

                    icm.greet();
                    icm.makeItem();
                    icm.notifyObservers();
                }
                if (line == "beverage")
                {
                    BeverageMaker bvgm = new BeverageMaker();

                    if (bvgm.NumBeverages < 0)
                    {
                        bvgm.soldOut();
                        continue;
                    }

                    bvgm.greet();
                    bvgm.makeItem();
                    bvgm.notifyObservers();
                }
            }
        }
    }
}
