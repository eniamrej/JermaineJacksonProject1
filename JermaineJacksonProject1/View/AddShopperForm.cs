
using JermaineJacksonProject1.Model;

namespace JermaineJacksonProject1.View
{
    public partial class AddShopperForm : Form
    {
        public Shopper? Shopper;

        public double Money;

        public AddShopperForm()
        {
            InitializeComponent();
        }

        private void AddShopperBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ShopperNameTxtBox.Text))
            {
                MessageBox.Show(@"Shopper name is required.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ShopperNameTxtBox.Focus();
                return;
            }

            if (!double.TryParse(MoneyTxtBox.Text, out Money) || Money < 0)
            {
                MessageBox.Show(@"Money must be a non-negative number.", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MoneyTxtBox.Focus();
                return;
            }

            Shopper = new Shopper(ShopperNameTxtBox.Text, Money);

            Close();
        }
    }
}
