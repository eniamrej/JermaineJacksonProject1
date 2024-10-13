
using JermaineJacksonProject1.Model;
using JermaineJacksonProject1.View;
using System.Windows.Forms;

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
                CarLotBox.Items.Add(car?.ToString() ?? throw new InvalidOperationException());
            }
        }

        private void newCarAdditionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _addCarForm = new AddCarForm();
            var dialog = _addCarForm.ShowDialog();

            if (dialog == DialogResult.OK)
            {
                if (_addCarForm.NewCar != null)
                {
                    CarLotBox.Items.Add(_addCarForm.NewCar);
                    _carLot.Inventory.Add(_addCarForm.NewCar);
                }
            }
        }

        private void ShopperBtn_Click(object sender, EventArgs e)
        {
            _addShopperForm = new AddShopperForm();
            _addShopperForm.ShowDialog();

            if (_addShopperForm.Shopper != null) ShopperBox.Items.Add(_addShopperForm.Shopper);
        }

        private void CarLotBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_addShopperForm?.Shopper == null)
            {
                MessageBox.Show(@"Shopper must be added before purchasing a car.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (CarLotBox.SelectedItems.Count > 0)
            {

                if (_addShopperForm.Shopper.CanPurchase(_carLot.Inventory[CarLotBox.SelectedIndex]).Equals(true))
                {
                    _addShopperForm.Shopper.PurchaseCar(_carLot.Inventory[CarLotBox.SelectedIndex] ??
                                                        throw new InvalidOperationException());
                    MessageBox.Show(
                        $@"Congrats you purchased this car: {_carLot.Inventory[CarLotBox.SelectedIndex]}{Environment.NewLine}Money available after purchase: {_addShopperForm.Shopper.MoneyAvailable:C2}");

                }
                else
                {
                    MessageBox.Show(
                        $@"Not enough money to purchase this car{Environment.NewLine}Money available: {_addShopperForm.Shopper.MoneyAvailable:C2}");
                }
            }
            else
            {
                MessageBox.Show(@"Please select an item");
            }
        }
    }
}
