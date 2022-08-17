using iStockMicro.Models;
using iStockMicro.ViewModels;

namespace iStockMicro.Views;

public partial class CodeListPage : ContentPage
{

    public CodeListViewModel viewmodel { get; set; }
    public CodeListPage()
	{
		InitializeComponent();
		this.BindingContext = viewmodel = new CodeListViewModel();
	}

    protected override  void OnAppearing()
    {
        base.OnAppearing();
        viewmodel.GetStockList();
    }
    private async void AddItems_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CodeSetupPage());
    }
}