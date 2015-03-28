using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderEntrySystem
{
    //
    // ISubject concrete class: Inventory
    // implements IObserver interface
    //
    public class Inventory : IObserver
    {

        //
        // Inventory class member variable
        //
        private static Inventory instance;

        //
        // ISubject member variables
        //
        private ISubject observable;
        private int numIceCreams, numPizzas, numBeverages;


        //
        // Inventory class ctor
        //
        private Inventory() { }

        //
        // Inventory class instance getter
        //
        public static Inventory getInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Inventory();
                }

                return instance;
            }
        }


        public static void registerWithSubject(ISubject observable)
        {
            instance.observable = observable;

            observable.addObserver(instance);
        }

        //
        //
        // IObserver method implementation
        //
        //
        public void update(int numIceCreams, int numPizzas, int numBeverages)
        {
            if (numIceCreams < 0)   { numIceCreams = 0; }
            if (numPizzas < 0)      { numPizzas = 0; }
            if (numBeverages < 0)   { numBeverages = 0; }

            instance.numIceCreams = numIceCreams;
            instance.numPizzas = numPizzas;
            instance.numBeverages = numBeverages;

            display();
        }


        //
        // Displays current state of inventory
        //
        public static void display()
        {
            Console.Write("Current inventory left:\n" +
                            "Ice Creams = " + instance.numIceCreams + "\n" +
                            "Pizzas = " + instance.numPizzas + "\n" +
                            "Beverages = " + instance.numBeverages + "\n\n");
        }

    }
}
