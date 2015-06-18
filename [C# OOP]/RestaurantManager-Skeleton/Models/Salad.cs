using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantManager
{
    using Interfaces;

    public class Salad : Meal, ISalad
    {
        public Salad(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare)
            : base(name, price, calories, quantityPerServing, timeToPrepare)
        {
        }

        public bool ContainsPasta { get; set; }
    }
}
