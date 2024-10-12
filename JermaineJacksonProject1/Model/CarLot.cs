

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
            Car firstCar = new Car("Ford","Focus ST", 28.3, 26298.98);
            _inventory.Add( firstCar );

            Car secondCar = new Car("Chevrolet", "Camaro ZL1", 19, 65401.23);
            _inventory.Add( secondCar );

            Car thirdCar = new Car("Honda", "Accord Sedan Ex", 30.2, 26780);
            _inventory.Add( thirdCar );

            Car fourthCar = new Car("Lexus", "ES 350", 24.1, 42101.10);
            _inventory.Add( fourthCar );

        }

        /// <summary>
        /// Finds the cars make.
        /// </summary>
        /// <param name="makeInInventory">The make in inventory.</param>
        /// <returns></returns>
        /// <exception cref="System.InvalidOperationException"></exception>
        public List<Car> FindCarsMake(string makeInInventory)
        {
            List<Car> cars = [];

            foreach (var car in _inventory)
            {
                if (car.Make.Equals(makeInInventory, StringComparison.OrdinalIgnoreCase))
                {
                    cars.Add(car);
                }
            }
            return (cars.Count > 0 ? cars : null) ?? throw new InvalidOperationException();
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
    }
}
