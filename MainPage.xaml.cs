using System;
using Microsoft.Maui.Controls;

namespace AndroidProject
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void CalculateButton_Clicked(object sender, EventArgs e)
        {
            int startNumber, endNumber, increment;

            if (int.TryParse(StartNumberEntry.Text, out startNumber) &&
                int.TryParse(EndNumberEntry.Text, out endNumber) &&
                int.TryParse(IncrementEntry.Text, out increment))
            {
                if (startNumber <= endNumber)
                {
                    ResultLabel.Text = GetNumbersBetween(startNumber, endNumber, increment);
                }
                else
                {
                    ResultLabel.Text = "Start number must be less than or equal to end number.";
                }
            }
            else
            {
                ResultLabel.Text = "Invalid input. Please enter valid numbers.";
            }
        }

        private string GetNumbersBetween(int start, int end, int increment)
        {
            string result = "";

            for (int i = start; i <= end; i += increment)
            {
                result += i + " ";
            }

            return result.Trim();
        }
    }
}
