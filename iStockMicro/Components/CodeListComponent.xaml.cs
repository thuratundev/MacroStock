using iStockMicro.Models;
using iStockMicro.ViewModels;

namespace iStockMicro.Components;

public partial class CodeListComponent : ContentView
{
    public Action<UsrCode> AddToCartItemExecute { get; set; }
    public CodeListComponent()
	{
		InitializeComponent();
        this.BindingContext = new CodeListComponentViewModel();
        
    }

    private void Pkr_CategorySelectionChanged(object sender, EventArgs e)
    {
        Category selectedCategory = (Category)(sender as Picker).SelectedItem;
    }
    private void CV_CodeListSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        AddToCartItemExecute((UsrCode)(sender as CollectionView).SelectedItem);
    }
}