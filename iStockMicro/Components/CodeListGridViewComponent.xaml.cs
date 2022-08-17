using iStockMicro.Models;
using iStockMicro.ViewModels;

namespace iStockMicro.Components;

public partial class CodeListGridViewComponent : ContentView
{
    public Action<UsrCode> AddToCartItemExecute { get; set; }
    public CodeListGridViewComponent()
	{
        InitializeComponent();
        this.BindingContext = new CodeListComponentViewModel();
      
    }

    private void Pkr_CategorySelectionChanged(object sender, EventArgs e)
    {

    }
}