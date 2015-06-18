namespace RestaurantManager
{
    using System;
    using System.Globalization;
    using System.Threading;
    using RestaurantManager.Engine;

    public class RestaurantManagementProgram
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            RestaurantManagerEngine.Instance.Start();

            Drink ajran = new Drink("ajran", 1m, 87, 300, 2, false);
            Console.WriteLine(ajran.Unit);
        }
    }
}