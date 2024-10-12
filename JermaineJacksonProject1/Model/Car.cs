
namespace JermaineJacksonProject1.Model
{
    /// <summary>
    /// Holds information on the cars in a list of cars
    /// </summary>
    public class Car
    {
        /// <summary>
        /// Stores the name of the care maker.
        /// </summary>
        /// <value>
        /// The make.
        /// </value>
        public string Make { get; set; }

        /// <summary>
        /// Stores the name of the car model.
        /// </summary>
        /// <value>
        /// The model.
        /// </value>
        public string Model { get; set; }

        /// <summary>
        /// Stores the number of miles per gallon of the car.
        /// </summary>
        /// <value>
        /// The MPG.
        /// </value>
        public double? Mpg { get; set; }

        /// <summary>
        /// Stores the price of the car.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        public double? Price { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Car"/> class.
        /// </summary>
        /// <param name="make">The make.</param>
        /// <param name="model">The model.</param>
        /// <param name="mpg">The MPG.</param>
        /// <param name="price">The price.</param>
        /// <exception cref="System.ArgumentException">
        /// make cannot be null, empty, or white space
        /// or
        /// model cannot be null, empty, or white space
        /// or
        /// mpg cannot be negative
        /// or
        /// price cannot be negative
        /// </exception>
        public Car(string make, string model, double mpg, double price)
        {
            if (string.IsNullOrWhiteSpace(make))
            {
                throw new ArgumentException("make cannot be null, empty, or white space");
            }

            if (string.IsNullOrWhiteSpace(model))
            {
                throw new ArgumentException("model cannot be null, empty, or white space");
            }

            if (mpg < 0)
            {
                throw new ArgumentException("mpg cannot be negative");
            }

            if (price < 0)
            {
                throw new ArgumentException("price cannot be negative");
            }

            Make = make;
            Model = model;
            Mpg = mpg; 
            Price = price;
        }

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return $"{Make} {Model}, MPG: {Mpg}, Price: ${Price:N2}";
        }
    }
}
