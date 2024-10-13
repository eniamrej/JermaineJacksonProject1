
using JermaineJacksonProject1.Model;
using JermaineJacksonProject1.View;

namespace JermaineJacksonProject1
{
    /// <summary>
    /// Main for of the project that stores all the cars in the carlot
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class CarLotForm : Form
    {
        private readonly CarLot _carLot;

        private AddCarForm? _addCarForm;

        private AddShopperForm? _addShopperForm;

        /// <summary>
        /// Initializes a new instance of the <see cref="CarLotForm"/> class.
        /// </summary>
        public CarLotForm()
        {
            InitializeComponent();
            _carLot = new CarLot();
            LoadDefaultCars();
        }

        private void LoadDefaultCars()
        {
            foreach (var car in _carLot.Inventory)
            {
                CarLotBox.Items.Add(car.ToString());
            }
        }

        private void newCarAdditionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _addCarForm = new AddCarForm();
            _addCarForm.ShowDialog();

            CarLotBox.Items.Add(_addCarForm.NewCar ?? throw new InvalidOperationException());
        }

        private void ShopperBtn_Click(object sender, EventArgs e)
        {
            _addShopperForm = new AddShopperForm();
            _addShopperForm.ShowDialog();


        }
    }
}
