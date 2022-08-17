using CommunityToolkit.Maui.Views;

namespace iStockMicro.Views;

public partial class TownshipPage : ContentPage
{
	public TownshipPage()
	{
		InitializeComponent();

      
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        var tsppopup = new TownshipPopUp();


        this.ShowPopup(tsppopup);
    }
}