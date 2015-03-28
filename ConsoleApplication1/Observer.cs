using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderEntrySystem
{
    //
    // Interface for the Subject
    //
    public interface ISubject
    {
        void addObserver(Inventory obj);
        void deleteObserver(Inventory obj);
        void notifyObservers();
    }


    //
    // Interface for all potential observers
    //
    interface IObserver
    {
        void update(int numIceCreams, int numPizzas, int numBeverages);
    }
}
