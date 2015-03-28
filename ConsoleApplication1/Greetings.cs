using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderEntrySystem
{
    //
    // GreetBehavior interface
    //
    interface IGreetBehavior
    {
        void greet();
    }


    //
    // GreetBehavior Concrete classes
    //

    //
    // Greet Cold class implementation
    //
    class GreetCold : IGreetBehavior
    {
        public void greet()
        {
            Console.Write("\nBrrr! \n");
        }
    }


    //
    // Greet Italian class implementation
    //
    class GreetItalian : IGreetBehavior
    {
        public void greet()
        {
            Console.Write("\nCiao! \n");
        }
    }


    //
    // Greet English class implementation
    //
    class GreetEnglish : IGreetBehavior
    {
        public void greet()
        {
            Console.Write("\nHi! \n");
        }
    }
}
