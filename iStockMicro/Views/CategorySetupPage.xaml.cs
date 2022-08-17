using iStockMicro.DataAccess;
using iStockMicro.Models;

namespace iStockMicro.Views;

public partial class CategorySetupPage : ContentPage
{
    SqlUtilities sqlUtilities;
    public CategorySetupPage()
	{
		InitializeComponent();
	}

    private async void btnSaveClicked(object sender, EventArgs e)
    {
        sqlUtilities = new SqlUtilities();

        string categoryName = txtcategoryname.Text;
        

        Category category = new Category {categoryname = categoryName};
        var recordcount = await sqlUtilities.Insert<Category>(category);

        if (recordcount > 0)
        {
            await DisplayAlert("Info", "You have been confirmed Successfully", "OK");
            await Navigation.PopAsync();

        }
    }
}