using Syncfusion.XForms.Cards;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace Cards_Reuse
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        int i = 0;
        public MainPage()
        {
            InitializeComponent();
            On<iOS>().SetUseSafeArea(true);
        }

        private async void SfCardView_Dismissed(System.Object sender, Syncfusion.XForms.Cards.DismissedEventArgs e)
        {
            await Task.Delay(400);
            i++;
            SfCardView view = sender as SfCardView;
            ((view.Content as StackLayout).Children[0] as Label).Text = "CardView " + i.ToString();
            view.IsDismissed = false;
        }

    }
}
