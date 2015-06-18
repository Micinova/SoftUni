namespace RestaurantManager
{
    using System;
    using Interfaces;
    using Models;

    public abstract class Recipe : IRecipe
    {
        private string name;
        private decimal price;
        private int calories;
        private int quantityPerServing;

        public Recipe(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare)
        {
            this.Name = name;
            this.Price = price;
            this.Calories = calories;
            this.QuantityPerServing = quantityPerServing;
            this.TimeToPrepare = timeToPrepare;
        }


        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(Messages.ArgumentCannotbeNullOrEmpty);
                }
                this.name = value;
                
            }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(Messages.CannotBeNegative);
                }
                this.price = value;
            }
        }

        public virtual int Calories
        {
            get { return this.calories; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(Messages.CannotBeNegative);
                }

                this.calories = value;
            }
        }

        public int QuantityPerServing
        {
            get { return this.quantityPerServing; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(Messages.CannotBeNegative);
                }
                this.quantityPerServing = value;
            }
        }

        public MetricUnit Unit { get; set; }

        public virtual int TimeToPrepare
        {
            get { return this.quantityPerServing; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(Messages.CannotBeNegative);
                }

                this.quantityPerServing = value;
            }
        }
    }
}
