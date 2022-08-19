
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Views;
using iStockMicro.Models;
using iStockMicro.ViewModels;


namespace iStockMicro.Views;

public partial class SaleEntryPage : ContentPage
{
    SaleEntryPageViewModel viewmodel;

    Customer customer;

    public SaleHead _SaleHead { get; set; }

    public List<SaleDet> _SaleDet { get; set; }
    public SaleEntryPage()
	{
		InitializeComponent();
        this.BindingContext = viewmodel = new SaleEntryPageViewModel();

        MessagingCenter.Subscribe<CheckOutPage>(this, "CheckoutExecuted", (sender) =>
        {
            RecalculateValue(sender);
        });

        _CodeListComponent.AddToCartItemExecute = DoAddToCartItemExecute;
        _CodeGridComponent.AddToCartItemExecute = DoAddToCartItemExecute;
        customer = new();

        if(viewmodel.SalesItemsList.Count() == 0)
        {
            frm_totalqty.IsVisible = false;
        }

    }

    private void RecalculateValue(CheckOutPage sender)
    {
        viewmodel.InvoiceAmount = sender.viewModel.SaleDet.Sum(x => x.saleprice??0 * x.unitqty??0);

        var _invoiceqty = sender.viewModel.SaleDet.Sum(x => x.unitqty ?? 0);
        viewmodel.InvoiceQty = _invoiceqty.ToString();

        if(_invoiceqty == 0)
        {
            frm_totalqty.IsVisible = false;
        }
    }

    private void DoAddToCartItemExecute(UsrCode usrcode)
    {
        viewmodel.SalesItemsList.Add(usrcode);
        viewmodel.InvoiceAmount = viewmodel.SalesItemsList.Sum(x => x.saleprice);
        viewmodel.InvoiceQty = viewmodel.SalesItemsList.Count().ToString();
        if(!frm_totalqty.IsVisible)
        {
            frm_totalqty.IsVisible = true;
        }
    }

    private  void AddCustomer_Clicked(object sender, EventArgs e)
    {
        var customerpopup = new CustomerSelectionPopup();

        customerpopup.Closed += CustomerPopUpClosed;
        this.ShowPopup(customerpopup);
    }

    private void CustomerPopUpClosed(object sender, PopupClosedEventArgs e)
    {
        customer = (e.Result as Customer);
    }

    private void ChangeListUI_Clicked(object sender, EventArgs e)
    {
        _CodeListComponent.IsVisible = true;
        _CodeGridComponent.IsVisible = false;
    }

    private void ChangeGridUI_Clicked(object sender, EventArgs e)
    {
        _CodeListComponent.IsVisible = false;
        _CodeGridComponent.IsVisible = true;
    }

    private async void Tapped_CheckOut(object sender, EventArgs e)
    {
        GetEntryVoucher();
        await Navigation.PushAsync(new CheckOutPage(_SaleHead,_SaleDet));
    }

    Func<string, string> getInoviceNo = x => x.Substring(x.Length - 4 , 4);

    private void GetEntryVoucher()
    {
        _SaleHead = new ();
        _SaleDet = new ();

        _SaleHead.tranid = Guid.NewGuid();
        _SaleHead.date = DateTime.Now;
        _SaleHead.customerid = customer.customerid;
        _SaleHead.customername = customer.customername;
        _SaleHead.invoiceno = _SaleHead.tranid.ToString().Substring(_SaleHead.tranid.ToString().Length - 4, 4);

        _SaleHead.invoiceno = getInoviceNo(_SaleHead.invoiceno);
        _SaleHead.customerid = 1;


        int srno = 0;
        viewmodel.SalesItemsList.ForEach(x => 
                    _SaleDet.Add(new SaleDet { srno = ++srno, tranid = _SaleHead.tranid , saleprice = x.saleprice , usrcode = x.usrcode , description = x.description, unitqty = 1  })
                    );
        

    }
}