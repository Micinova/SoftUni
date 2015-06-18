using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantManager
{
    using Interfaces;

    public class Dessert : Meal, IDessert
    {
        public Dessert(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare) 
            : base(name, price, calories, quantityPerServing, timeToPrepare)
        {
        }

        public bool WithSugar { get; set; }

        public void ToggleSugar()
        {
        }
    }
}
