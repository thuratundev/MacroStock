using iStockMicro.Models;
using iStockMicro.ViewModels;

namespace iStockMicro.Views;

public partial class CheckOutPage : ContentPage
{
    public CheckOutViewModel viewModel { get; set; }
    public CheckOutPage()
	{
		InitializeComponent();
	}
	
	public CheckOutPage(SaleHead _salehead,List<SaleDet> _saledet)
    {
		InitializeComponent();
		this.BindingContext = viewModel = new CheckOutViewModel();

		viewModel.SaleHead = _salehead;
        viewModel.SaleDet = new ();
        _saledet.ForEach(x => viewModel.SaleDet.Add(x));

        viewModel.CalculateTotalValues();

    }

    private void Confirm_Clicked(object sender, EventArgs e)
    {

    }

    private void OnDeleteSwipeItemInvoked(object sender, EventArgs e)
    {
        var deleteditem = viewModel.SaleDet.Where(x => x.srno == ((SaleDet)cv_checkoutlist.SelectedItem).srno).FirstOrDefault();
        viewModel.SaleDet.Remove(deleteditem);
        viewModel.CalculateTotalValues();
    }
}