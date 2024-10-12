
using JermaineJacksonProject1.Model;

namespace JermaineJacksonProject1
{
    public partial class CarLotForm : Form
    {
        public readonly List<Car> inventoryCars;

        public CarLotForm()
        {
            InitializeComponent();
            LoadDefaultCars();
        }

        private void LoadDefaultCars()
        {
          
        }
    }
}
