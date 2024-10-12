

namespace JermaineJacksonProject1.Model
{
    /// <summary>
    /// Holds the data for cars in the list
    /// </summary>
    public class CarLot
    {
        private readonly List<Car> _inventory;

        /// <summary>
        /// A constant that declares the tax rate as 7.8 percent
        /// </summary>
        public const double TaxRate = 0.078;

        /// <summary>
        /// Returns the total number of cars within the inventory.
        /// </summary>
        /// <value>
        /// The count of the list.
        /// </value>
        public int Count => _inventory.Count;

        /// <summary>
        /// Returns the list of the store's inventory.
        /// </summary>
        /// <value>
        /// The inventory of the list.
        /// </value>
        public List<Car> Inventory => _inventory;

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
        /// <returns>A list of the car objects that matches the make or null if the make is not found in the list</returns>
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

        /// <summary>
        /// Finds the car by make model.
        /// </summary>
        /// <param name="make">The make.</param>
        /// <param name="model">The model.</param>
        /// <returns>A car object with matching make and model or null if car object not matching make and model is not in the inventory</returns>
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

        /// <summary>
        /// Removes a car from the list with the matching make and model.
        /// </summary>
        /// <param name="make">The make.</param>
        /// <param name="model">The model.</param>
        /// <returns>The car that was removed from the list or null if the car was not found in the inventory list</returns>
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

        /// <summary>
        /// Creates a new car object and adds that car to the list.
        /// </summary>
        /// <param name="make">The make.</param>
        /// <param name="model">The model.</param>
        /// <param name="mpg">The MPG.</param>
        /// <param name="price">The price.</param>
        public void AddCar(string make, string model, double mpg, double price)
        {
            Car addedCar = new Car(make, model, mpg, price);
            _inventory.Add(addedCar);
        }

        /// <summary>
        /// Gets the total cost of a car object based on the car objects price.
        /// </summary>
        /// <param name="car">The car.</param>
        /// <returns>the total cost of a car object based on the car objects price</returns>
        public double GetTotalCostOfPurchase(Car car)
        {
            double totalCost = (double)car.Price! + ((double)car.Price! * TaxRate);
            return totalCost;
        }

        /// <summary>
        /// Finds the least expensive car.
        /// </summary>
        /// <returns>the car object with the smallest price or null if the list is empty</returns>
        public Car FindLeastExpensiveCar()
        {
            for (int i = 0; i < _inventory.Count; i++)
            {
                for (int j = i + 1; j < _inventory.Count; j++)
                {
                    if (GetTotalCostOfPurchase(_inventory[i]) < GetTotalCostOfPurchase(_inventory[j]))
                    {
                        return _inventory[i];
                    }
                }
            }
            return null!;
        }

        /// <summary>
        /// Finds the most expensive car.
        /// </summary>
        /// <returns>the car object with the biggest price or null if the list is empty</returns>
        public Car FindMostExpensiveCar()
        {
            for (int i = 0; i < _inventory.Count; i++)
            {
                for (int j = i + 1; j < _inventory.Count; j++)
                {
                    if (GetTotalCostOfPurchase(_inventory[i]) > GetTotalCostOfPurchase(_inventory[j]))
                    {
                        return _inventory[i];
                    }
                }
            }
            return null!;
        }

        /// <summary>
        /// Finds the best MPG of the car objects in the list.
        /// </summary>
        /// <returns>the car with the best mpg</returns>
        public Car FindBestMpgCar()
        {
            if (_inventory.Count == 0)
            {
                return null!;
            }

            Car bestMpgCar = _inventory[0];
            for (int i = 1; i < _inventory.Count; i++)
            {
                if (_inventory[i].Mpg > bestMpgCar.Mpg)
                {
                    bestMpgCar = _inventory[i];
                }
            }
            return bestMpgCar;
        }

        /// <summary>
        /// Finds the worst MPG of the car objects in the list.
        /// </summary>
        /// <returns>the car with best mpg</returns>
        public Car FindWorstMpgCar()
        {
            if (_inventory.Count == 0)
            {
                return null!;
            }

            Car worstMpgCar = _inventory[0];
            for (int i = 1; i < _inventory.Count; i++)
            {
                if (_inventory[i].Mpg < worstMpgCar.Mpg)
                {
                    worstMpgCar = _inventory[i];
                }
            }
            return worstMpgCar;
        }

    }
}
