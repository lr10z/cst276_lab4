using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderEntrySystem
{
    //
    // 
    // Abstract class Maker
    // extends ISubject interface
    //
    abstract class Maker : ISubject
    {
        // Maker variables
        private List<IObserver> observers;
        protected static int numIceCreams = 2, numPizzas = 2, numBeverages = 2;
        protected IGreetBehavior greetingBehavior;
        protected IMakeItemBehavior makeItemBehavior;

        // Maker ctor
        public Maker() 
        {
            observers = new List<IObserver>();
            addObserver(Inventory.getInstance);
        }

        // Maker methods
        public void greet()     {greetingBehavior.greet();}
        public void makeItem()  {makeItemBehavior.makeItem();}
        public void soldOut()   
        {
            Console.Write( "\nSorry that item is sold out :(\n\n");
            return;
        }


        //
        // Product count getters
        //
        public int NumIceCreams { get { return numIceCreams; } }
        public int NumPizzas { get { return numPizzas; } }
        public int NumBeverages { get { return numBeverages; } }
        
        
        //
        // ISubject methods implemented: add, delete, notify
        //
        public void addObserver(Inventory newObserver)
        {
            observers.Add(newObserver);
        }
        public void deleteObserver(Inventory deleteObserver)
        {
            if (observers.Contains(deleteObserver))
            {
                observers.Remove(deleteObserver);
            }
        }
        public void notifyObservers()
        {
            foreach (IObserver observer in observers)
            {
                observer.update(numIceCreams, numPizzas, numBeverages);
            }
        }        
    }



    //
    // 
    // Concrete Makers
    //
    //

    //
    // Ice Cream Maker
    //
    class IceCreamMaker : Maker
    {
        public IceCreamMaker()
        {
            greetingBehavior = new GreetCold();
            makeItemBehavior = new MakeIceCream();
            numIceCreams -= 1;
        }
    }

    //
    // Pizza Maker
    //
    class PizzaMaker : Maker
    {
        public PizzaMaker()
        {
            greetingBehavior = new GreetItalian();
            makeItemBehavior = new MakePizza();
            numPizzas -= 1;
        }
    }

    //
    // Beverage Maker
    //
    class BeverageMaker : Maker
    {
        public BeverageMaker()
        {
            greetingBehavior = new GreetEnglish();
            makeItemBehavior = new MakeBeverage();
            numBeverages -= 1;
        }
    }
}
