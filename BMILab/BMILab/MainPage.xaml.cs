using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BMILab
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Clicked(object sender, EventArgs e)
        {
            float Height = (float)Convert.ToDecimal(HeightEntry.Text);
            float Weight = (float)Convert.ToDecimal(WeightEntry.Text);
            float bmi = Weight / (Height * Height);
            lblAnswer.Text = "Your BMI is : " + bmi.ToString();
        }
    }
}
