using JermaineJacksonProject1.Model;

namespace JermaineJacksonProject1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonClk(object sender, EventArgs e)
        {
            CarLot mCarLot = new CarLot();
            string? output = mCarLot.PurchaseCar("ford", "focus st").ToString();
            label1.Text = output;
        }
    }
}
