using iStockMicro.DataAccess;
using iStockMicro.Models;

namespace iStockMicro.Views;

public partial class CodeSetupPage : ContentPage
{
	SqlUtilities sqlUtilities;
	public CodeSetupPage()
	{
		InitializeComponent();
        sqlUtilities = new SqlUtilities();
        InitializeData();
        
	}

    private async void InitializeData()
    {
        CategoryPicker.ItemsSource = await sqlUtilities.GetListAsync<Category>();
     
    }

    private async void btnSaveClicked(object sender, EventArgs e)
    {
       

        string usrcode = txtusrcode.Text;
		string description = txtdescription.Text;
		decimal saleprice = decimal.Parse(txtsaleprice.Text);
        int? categoryid = (CategoryPicker.SelectedItem as Category).categoryid;

		UsrCode usrCode = new UsrCode { usrcode = usrcode,description = description,saleprice = saleprice,categoryId = categoryid };
		var recordcount = await sqlUtilities.Insert<UsrCode>(usrCode);

		if(recordcount > 0)
        {
            await DisplayAlert("Info", "You have been confirmed Successfully", "OK");
			await Navigation.PopAsync();

        }
    }
}