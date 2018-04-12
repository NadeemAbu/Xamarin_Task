using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QuoteApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class QuotesPage : ContentPage
	{
        string[] quotes = { "But man is not made for defeat. A man can be destroyed but not defeated.",
                            "When you reach the end of your rope, tie a knot in it and hang on.",
                            "Let us sacrifice our today so that our children can have a better tomorrow.",
                            "It is better to be feared than loved, if you cannot be both." ,
                            "Do not mind anything that anyone tells you about anyone else. Judge everyone and everything for yourself."};


        public QuotesPage()
        {
            InitializeComponent();
            sliderLabel.Text = "Font Size: 16 ";
            quoteslabel.Text = "But man is not made for defeat.A man can be destroyed but not defeated.";
        }  

        private void slide_Handler(object sender, ValueChangedEventArgs e)
        {
            sliderLabel.Text ="Font Size: " + Math.Round (slider.Value);
            quoteslabel.FontSize = slider.Value;
            
        }

        int currentquote = 0;
        private void Nextbt_Click(object sender, EventArgs e)
        {
            if (currentquote < 4)
            { 
                currentquote++;
                quoteslabel.Text = quotes[currentquote];
            }
            else
            {
                currentquote = 0;
                quoteslabel.Text = quotes[currentquote];
            }
        }
    }
}