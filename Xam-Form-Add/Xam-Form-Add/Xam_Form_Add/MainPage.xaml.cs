using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Xam_Form_Add
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void AddClicked(object sender, EventArgs e)
        {
            var numA = Convert.ToDouble(ValueAEntry.Text); // asume entry values are numbers
            var numB = Convert.ToDouble(ValueBEntry.Text);
            bool isNumAInt = numA % 1 == 0;
            bool isNumBInt = numB % 1 == 0;
            var sum = numA + numB;

            ResultLabel.Text = sum.ToString();

            //for fun
            if (numA > 0 && numB > 0 && isNumAInt && isNumBInt)
            {
                if (sum > 11 && sum <= 20)
                    ResultLabel.Text = "Use Ur Brain";
                else if (sum > 0 && sum <= 10)
                    ResultLabel.Text = "dah, use ur fingers";
            }
            
                
        }
        private void SubtractClicked(object sender, EventArgs e)
        {
            ResultLabel.Text = (Convert.ToDouble(ValueAEntry.Text) -
                Convert.ToDouble(ValueBEntry.Text)).ToString();
        }
    }
}
