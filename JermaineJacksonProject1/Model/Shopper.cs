
namespace JermaineJacksonProject1.Model
{
    public class Shopper
    {
        /// <summary>
        /// Stores the name of a shopper.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Stores the amount of money currently available for the shopper.
        /// </summary>
        /// <value>
        /// The money available.
        /// </value>
        public double MoneyAvailable { get; set; }

        private readonly List<Car> _cars;

        private CarLot? _carLot;

        /// <summary>
        /// Initializes a new instance of the <see cref="Shopper"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="moneyAvailable">The money available.</param>
        /// <exception cref="System.ArgumentException">
        /// model cannot be null, empty, or white space
        /// or
        /// mpg cannot be negative
        /// </exception>
        public Shopper(string name, double moneyAvailable)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("model cannot be null, empty, or white space");
            }

            if (moneyAvailable < 0)
            {
                throw new ArgumentException("mpg cannot be negative");
            }

            _cars = new List<Car>();
            Name = name;
            MoneyAvailable = moneyAvailable;
        }

        /// <summary>
        /// Determines whether this instance can purchace the specified car.
        /// </summary>
        /// <param name="car">The car.</param>
        /// <returns>
        ///   <c>true</c> if this instance can purchace the specified car; otherwise, <c>false</c>.
        /// </returns>
        /// <exception cref="System.ArgumentNullException">car</exception>
        public Boolean CanPurchase(Car? car)
        {
            _carLot = new CarLot();

            if (car == null)
            {
                throw new ArgumentNullException(nameof(car));
            }

            if (MoneyAvailable >= _carLot.GetTotalCostOfPurchase(car))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Give the remaining balance of the money available after a purchase of a car is made.
        /// </summary>
        /// <param name="car">The car.</param>
        /// <exception cref="System.ArgumentNullException">car</exception>
        public void PurchaseCar(Car car)
        {
            if (car == null)
            {
                throw new ArgumentNullException(nameof(car));
            }

            _cars.Add(car);

            MoneyAvailable = MoneyAvailable - (double)car.Price!;
        }

        /// <summary>
        /// Displays the purchased cars.
        /// </summary>
        public void DisplayPurchasedCars()
        {
            foreach (var car in _cars)
            {
                Console.WriteLine($@"{car.Make} {car.Model} - ${car.Price}");
            }
        }

        /// <summary>
        /// Displays the shoppers name and money available and converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return $"{Name}, {MoneyAvailable:C}";
        }
    }
}
