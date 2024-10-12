
using JermaineJacksonProject1.Model;

namespace JermaineJacksonProject1
{
    public partial class CarLotForm : Form
    {
        public readonly List<Car> inventoryCars;

        public CarLot carLot;

        public CarLotForm()
        {
            InitializeComponent();
            inventoryCars = new List<Car>();
            inventoryCars.
            LoadDefaultCars();
        }

        private void LoadDefaultCars()
        {
          
        }
    }
}
