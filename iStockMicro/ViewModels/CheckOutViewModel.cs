using iStockMicro.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iStockMicro.ViewModels
{
    public class CheckOutViewModel : BaseViewModel
    {
        private decimal? _InvoiceAmount;
        public decimal? InvoiceAmount
        {
            get { return _InvoiceAmount; }
            set
            {
                if (value != this._InvoiceAmount)
                {
                    this._InvoiceAmount = value;
                    NotifyPropertyChanged();
                }
            }
        }


        private string _InvoiceQty;
        public string InvoiceQty
        {
            get { return (_InvoiceQty ?? String.Empty).Length == 1 ? String.Concat(" ", _InvoiceQty) : _InvoiceQty; }
            set
            {
                if (value != this._InvoiceQty)
                {
                    this._InvoiceQty = value;
                    NotifyPropertyChanged();
                }
            }
        }

       

        private SaleHead _SaleHead;

        public SaleHead SaleHead
        {
            get { return _SaleHead; }
            set 
            {
                if(value != this._SaleHead)
                {
                    _SaleHead = value;
                    NotifyPropertyChanged();
                }
                 
            }
        }


        private ObservableCollection<SaleDet> _SaleDet;
        public ObservableCollection<SaleDet> SaleDet
        {
            get { return _SaleDet; }
            set
            {
                if (value != this._SaleDet)
                {
                    this._SaleDet = value;
                    NotifyPropertyChanged();
                }
            }
        }


        public void CalculateTotalValues()
        {
            InvoiceAmount = SaleDet.Sum(x => (x.saleprice ?? 0 * x.unitqty ?? 1));
            InvoiceQty = SaleDet.Sum(x =>  x.unitqty ?? 1).ToString();
        }
    }
}
