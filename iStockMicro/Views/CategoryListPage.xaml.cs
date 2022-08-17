using iStockMicro.ViewModels;

namespace iStockMicro.Views;

public partial class CategoryListPage : ContentPage
{
    CategoryListViewModel viewModel;
	public CategoryListPage()
	{
		InitializeComponent();
        this.BindingContext = viewModel = new CategoryListViewModel();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        viewModel.GetStockList();
    }

    private async void AddItems_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CategorySetupPage());
    }
}