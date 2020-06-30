# Reuse-the-cards-in-Xamarin.Forms-SfCardView

This section explains how to reuse a dismissed card in SfCardView. This allows reusing a single card for showing different content with every swipe. This will optimize the memory usage of your Xamarin application by avoid creating separate card for each content. For more please refer the below KB

[How to reuse the dismissed cards in Xamarin.Forms SfCardView](https://www.syncfusion.com/kb/11648/?utm_medium=listing&utm_source=github-examples)

 
You can refer to this [Getting Started](https://help.syncfusion.com/xamarin/cards/getting-started?_ga=2.144022709.1232783100.1593359517-1450022673.1574142796) documentation for more details about the CardView.


[SfCardView](https://help.syncfusion.com/xamarin/cards/getting-started?_ga=2.181927463.1232783100.1593359517-1450022673.1574142796#sfcardview) supports dismissing a card from the view by enabling the [SwipeToDismiss](https://help.syncfusion.com/xamarin/cards/getting-started?_ga=2.181927463.1232783100.1593359517-1450022673.1574142796#swipetodismiss) property. This property also enables reusing the dismissed card to optimize the memory usage of your Xamarin application. Please refer the below code snippet to reuse the dismissed card.

 

To add cards to your project, open the NuGet package manager in Visual Studio, search for [Syncfusion.Xamarin.Cards](https://www.nuget.org/packages/Syncfusion.Xamarin.Cards/), and then install it.


**[XAML]**
```
<StackLayout HorizontalOptions="Fill" VerticalOptions="Center">
 
            <!--  CardView with SwipeToDismiss property enabled  -->
            <cards:SfCardView
                SwipeToDismiss="True"
                Dismissed="SfCardView_Dismissed"
                HorizontalOptions="Center"
                VerticalOptions="Center">
 
                <!--  Label to show a content inside card  -->
                <Label
                    BackgroundColor="Red"
                    FontSize="Large"
                    HeightRequest="100"
                    HorizontalOptions="CenterAndExpand"
                    HorizontalTextAlignment="Center"
                    Text="Card View"
                    TextColor="White"
                    VerticalOptions="CenterAndExpand"
                    VerticalTextAlignment="Center"
                    WidthRequest="300" />
 
            </cards:SfCardView>
 
</StackLayout>
```

**[C#]**

```

private int cardNumber;
 
private async void SfCardView_Dismissed(System.Object sender, Syncfusion.XForms.Cards.DismissedEventArgs e)
        {
            await Task.Delay(400);
            SfCardView view = sender as SfCardView;
            (view.Content as Label).Text = "Card View " + cardNumber.ToString();
            view.IsDismissed = false;
            cardNumber++;
        }
```
 
**SwipeToDismiss Property won’t work when you add the SfCardView as a child of SfCardLayout**

Also refer our [feature tour page](https://www.syncfusion.com/xamarin-ui-controls/xamarin-cards) to know more features available in our button.

# Troubleshooting
## Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.
