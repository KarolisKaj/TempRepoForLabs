namespace Plukas1Client
{
    using FactoryStructs;
    using Products;
    using System;
    using Values;

    public class FactoryServiceSingleton
    {
        private FactoryServiceSingleton() { }
        private static Type[] candyTypes = new Type[] { typeof(CandyCaramel), typeof(CandyChocolade) };
        private static Type[] drinkTypes = new Type[] { typeof(DrinkAlchohol), typeof(DrinkEnergy) };
        private static Type[] meatTypes = new Type[] { typeof(MeatBeef), typeof(MeatChicken) };
        private static object[] candyDefaults = new object[] { "Caramel", "Fruits", 50 };
        private static object[] drinkDefaults = new object[] { "Hitter", "Whiskey", 37 };
        private static object[] meatDefaults = new object[] { 17, Served.Cold };
        private static object _lockRoot = new object();
        private static IMeatCandyAndDrinkFactory _productFactory;
        public static IMeatCandyAndDrinkFactory ProductFactory
        {
            get
            {
                if (_productFactory == null)
                    lock (_lockRoot)
                        if (_productFactory == null)
                            _productFactory = new CandyDrinkAndMeatTypeFactory(candyTypes, meatTypes, drinkTypes, meatDefaults, candyDefaults, drinkDefaults);

                return _productFactory;
            }
        }
    }
}
