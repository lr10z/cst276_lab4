using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderEntrySystem
{
    //
    // IPizzaIngredientFactory interface
    //
    interface IPizzaIngredientFactory
    {
        Dough CreateDough();
        Sauce CreateSauce();
        Cheese CreateCheese();
        Pepperoni CreatePepperoni();
    }


    //
    // Abstract ingredient classes declared
    //
    abstract class Dough {}
    abstract class Sauce {}
    abstract class Cheese {}
    abstract class Pepperoni {}


    //
    // Concrete ingredient classes implemented
    //
    class ThickCrustDough : Dough 
    { 
        public override string ToString(){ return "Thick dough"; } 
    }
    class ThinCrustDough : Dough
    {
        public override string ToString() { return "Thin dough"; }
    }
    class MarinaraSauce : Sauce
    {
        public override string ToString() { return "Marinara sauce"; }
    }
    class PlumTomatoSauce : Sauce
    {
        public override string ToString() { return "Plum tomato sauce"; }
    }
    class ReggianoCheese : Cheese
    {
        public override string ToString() { return "Reggiano cheese"; }
    }
    class MozarellaCheese : Cheese
    {
        public override string ToString() { return "Mozarella cheese"; }
    }
    class SlicedPepperoni : Pepperoni
    {
        public override string ToString() { return "Sliced pepperoni"; }
    }
    

    //
    // Concrete IPizzaIngredientFactory class
    //
    // NY Ingredient Factory implementation
    //
    class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Dough CreateDough() { return new ThinCrustDough(); }
        public Sauce CreateSauce() { return new MarinaraSauce(); }
        public Cheese CreateCheese() { return new ReggianoCheese(); }
        public Pepperoni CreatePepperoni() { return new SlicedPepperoni(); }
    }


    //
    // Concrete IPizzaIngredientFactory class
    //
    //
    // Chicago Ingredient Factory implementation
    //
    class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Dough CreateDough() { return new ThickCrustDough(); }
        public Sauce CreateSauce() { return new PlumTomatoSauce(); }
        public Cheese CreateCheese() { return new MozarellaCheese(); }
        public Pepperoni CreatePepperoni() { return new SlicedPepperoni(); }
    }


    //
    // Concrete Pizza class
    //
    // Cheese pizza implementation
    //
    class CheesePizza : Pizza
    {
        IPizzaIngredientFactory ingredientFactory;

        public CheesePizza(IPizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            dough = ingredientFactory.CreateDough();
            sauce = ingredientFactory.CreateSauce();
            cheese = ingredientFactory.CreateCheese();
            
            Console.Write("\nPreparing " + 
                            Name + "\n" + 
                            dough.ToString() + "\n" +  
                            sauce.ToString() + "\n" +
                            cheese.ToString() + "\n\n");
        }
    } 


    //
    // Concrete Pizza class
    //
    // Pepperoni implementation
    //
    class PepperoniPizza : Pizza
    {
        IPizzaIngredientFactory ingredientFactory;

        public PepperoniPizza(IPizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            dough = ingredientFactory.CreateDough();
            sauce = ingredientFactory.CreateSauce();
            cheese = ingredientFactory.CreateCheese();
            pepperoni = ingredientFactory.CreatePepperoni();

            Console.Write("\nPreparing " +
                            Name + "\n" +
                            dough.ToString() + "\n" +
                            sauce.ToString() + "\n" +
                            cheese.ToString() + "\n" +
                            pepperoni.ToString() + "\n\n");
        }

    } 


}
