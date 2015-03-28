using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderEntrySystem
{
    //
    // Abstract Pizza class
    //
    abstract class Pizza
    {
        private string name;
        protected Dough dough;
        protected Sauce sauce;
        protected Cheese cheese;
        protected Pepperoni pepperoni;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public abstract void Prepare();
        public void Bake() { Console.Write("Bake for 25 minutes at 350 \n"); }
        public void Cut() { Console.Write("Cutting the pizza into diagonal slices \n"); }
        public void Box() { Console.Write("Place pizza in official pizza box \n"); }
    } 


    //
    // Abstract PizzaType class
    //
    abstract class PizzaType
    {
        public Pizza OrderPizza(string type)
        {
            Pizza pizza = this.CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        protected abstract Pizza CreatePizza(string type);
    }



    
    //
    // Concrete PizzaType class
    // 
    // NY Pizza implementation
    //
    class NYPizza : PizzaType
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            IPizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();

            switch (type)
            {
                case "cheese":
                    pizza = new CheesePizza(ingredientFactory);
                    pizza.Name = "New York Style Cheese Pizza";
                    break;

                case "pepperoni":
                    pizza = new PepperoniPizza(ingredientFactory);
                    pizza.Name = "New York Style Pepperoni Pizza";
                    break;
            }

            return pizza;
        }

    }


    //
    // Concrete PizzaType class
    //
    // Chicago Pizza implementation
    //
    class ChicagoPizza : PizzaType
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            IPizzaIngredientFactory ingredientFactory = new ChicagoPizzaIngredientFactory();

            switch (type)
            {
                case "cheese":
                    pizza = new CheesePizza(ingredientFactory);
                    pizza.Name = "Chicago Style Cheese Pizza";
                    break;

                case "pepperoni":
                    pizza = new PepperoniPizza(ingredientFactory);
                    pizza.Name = "Chicago Style Pepperoni Pizza";
                    break;
            }

            return pizza;
        }

    }

}
