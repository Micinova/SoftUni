using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantManager
{
    using Interfaces;
    using Models;

    public class MainCourse : Meal, IMainCourse
    {
        public MainCourse(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare)
            : base(name, price, calories, quantityPerServing, timeToPrepare)
        {
        }

        public MainCourseType Type
        {
            get { throw new NotImplementedException(); }
        }
    }
}
