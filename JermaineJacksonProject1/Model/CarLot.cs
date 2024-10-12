

namespace JermaineJacksonProject1.Model
{
    internal class CarLot
    {
        private readonly List<Car> _inventory;

        /// <summary>
        /// A constant that declares the tax rate as 7.8 percent
        /// </summary>
        public const decimal TaxRate = 0.078m;

        /// <summary>
        /// Initializes a new instance of the <see cref="CarLot"/> class.
        /// </summary>
        public CarLot()
        {
            _inventory = new List<Car>();
            StockLotWithDefaultInventory();
        }

        private void StockLotWithDefaultInventory()
        {
            AddCar("Ford","Focus ST", 28.3, 26298.98);
            AddCar("Chevrolet", "Camaro ZL1", 19, 65401.23);
            AddCar("Honda", "Accord Sedan Ex", 30.2, 26780);
            AddCar("Lexus", "ES 350", 24.1, 42101.10);
        }

        /// <summary>
        /// Finds the cars make.
        /// </summary>
        /// <param name="makeInInventory">The make in inventory.</param>
        /// <returns></returns>
        /// <exception cref="System.InvalidOperationException"></exception>
        public List<Car> FindCarsByMake(string makeInInventory)
        {
            foreach (var car in _inventory)
            {
                if (car.Make.Equals(makeInInventory, StringComparison.OrdinalIgnoreCase))
                {
                    return _inventory;
                }
            }
            return null!;
        }

        public Car FindCarByMakeModel(string make, string model)
        {
            foreach (var car in _inventory)
            {
                if (car.Make.Equals(make, StringComparison.OrdinalIgnoreCase) &
                    car.Model.Equals(model, StringComparison.OrdinalIgnoreCase))
                {
                    return car;
                }
            }
            return null!;
        }

        public Car PurchaseCar(string make, string model)
        {
            foreach (var car in _inventory)
            {
                if (car.Make.Equals(make, StringComparison.OrdinalIgnoreCase) &
                    car.Model.Equals(model, StringComparison.OrdinalIgnoreCase))
                {
                    _inventory.Remove(car);
                    return car;
                }
            }
            return null!;
        }

        public void AddCar(string make, string model, double mpg, double price)
        {
            Car addedCar = new Car(make, model, mpg, price);
            _inventory.Add(addedCar);
        }
    }
}
