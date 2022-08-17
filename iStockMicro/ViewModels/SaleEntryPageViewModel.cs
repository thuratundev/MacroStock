using iStockMicro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iStockMicro.ViewModels
{
    public class SaleEntryPageViewModel : BaseViewModel
    {
        public SaleEntryPageViewModel()
        {
            SalesItemsList = new List<UsrCode>();
        }
        private List<UsrCode> _SalesItemsList;
        public List<UsrCode> SalesItemsList
        {
            get { return _SalesItemsList; }
            set
            {
                if (value != this._SalesItemsList)
                {
                    this._SalesItemsList = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private decimal? _InvoiceAmount;
        public decimal? InvoiceAmount
        {
            get { return _InvoiceAmount; }
            set 
            {
                if(value != this._InvoiceAmount)
                {
                    this._InvoiceAmount = value;
                    NotifyPropertyChanged();
                }
            }
        }


        private string _InvoiceQty;
        public string InvoiceQty
        {
            get { return (_InvoiceQty??String.Empty).Length == 1 ?  String.Concat(" ",_InvoiceQty): _InvoiceQty; }
            set
            {
                if (value != this._InvoiceQty)
                {
                    this._InvoiceQty = value;
                    NotifyPropertyChanged();
                }
            }
        }


    }
}
