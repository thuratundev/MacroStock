using iStockMicro.Views;

namespace iStockMicro;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private async void BtnItemCode_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CodeSetupPage());
    }

    private async void BtnItemCodeList_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CodeListPage());
    }

    private async void BtnCategory_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CategorySetupPage());
    }

    private async void BtnCategoryList_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CategoryListPage());
    }

    private async void BtnSaleEntry_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SaleEntryPage());
      
    }

    private void BtnSalesEntryList_Clicked(object sender, EventArgs e)
    {

    }
}

