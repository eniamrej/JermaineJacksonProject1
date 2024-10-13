
using JermaineJacksonProject1.Model;

namespace JermaineJacksonProject1.View
{
    public partial class AddCarForm : Form
    {
        /// <summary>
        /// Stores information for a new car.
        /// </summary>
        public Car? NewCar;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddCarForm"/> class.
        /// </summary>
        public AddCarForm()
        {
            InitializeComponent();
        }

        private void AddNewCarBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MakeTxtBox.Text))
            {
                MessageBox.Show(@"Make is required.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MakeTxtBox.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(ModelTxtBox.Text))
            {
                MessageBox.Show(@"Model is required.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ModelTxtBox.Focus();
                return;
            }

            if (!double.TryParse(MpgTxtBox.Text, out double mpg) || mpg <= 0)
            {
                MessageBox.Show(@"MPG must be a positive number.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MpgTxtBox.Focus();
                return;
            }

            if (!double.TryParse(PriceTxtBox.Text, out double price) || price < 0)
            {
                MessageBox.Show(@"Price must be a non-negative number.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PriceTxtBox.Focus();
                return;
            }

            NewCar = new Car(MakeTxtBox.Text, ModelTxtBox.Text, mpg, price);

            Close();
        }
    }
}
