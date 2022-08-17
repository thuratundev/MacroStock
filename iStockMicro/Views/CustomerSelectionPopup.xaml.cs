using CommunityToolkit.Maui.Views;
using CommunityToolkit.Maui.Core;

using iStockMicro.Models;
using iStockMicro.ViewModels;

namespace iStockMicro.Views;

public partial class CustomerSelectionPopup : Popup
{
	CustomerViewModel viewModel;

    
    public CustomerSelectionPopup()
	{
		InitializeComponent();
		this.BindingContext = viewModel = new CustomerViewModel();
		viewModel.GetCustomers();
        AnimateUI();
    }

    private async void AnimateUI()
    {
       await  this.Content.TranslateTo(400, 0, 0);
       await this.Content.TranslateTo(0, 0, 700, Easing.CubicIn);

        //ResetState();

    }

    private async void lsv_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        //this.Close((sender as ListView).SelectedItem);


        //this.Parent  = new NavigationPage(new TownshipPage());

        await (this.Parent as Page).Navigation.PushAsync(new TownshipPage());

        //var tsppopup = new TownshipPopUp();

        
        //(this.Parent as Page).ShowPopup(tsppopup);


  
    }
}