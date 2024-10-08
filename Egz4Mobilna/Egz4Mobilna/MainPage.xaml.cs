using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Egz4Mobilna
{
    public partial class MainPage : ContentPage
    {
        public static string[] quotes = new string[3] { "Dzień dobry", "Good morning", "Buenos dias" };
        int counter = 0;
        public MainPage()
        {
            InitializeComponent();
            quote.Text = quotes[0];
        }

        private void ChangeQuote(object sender, EventArgs e)
        {
            if (counter < 2)
            {
                counter++;
                quote.Text = quotes[counter];
            }
            else
            {
                counter = 0;
                quote.Text = quotes[counter];
            }
        }

        private void ChangeFontSize(object sender, ValueChangedEventArgs e)
        {
            int fontSize = (int)e.NewValue;
            fontSizeLbl.Text = fontSize.ToString();

            quote.FontSize = fontSize;
        }
    }
}
