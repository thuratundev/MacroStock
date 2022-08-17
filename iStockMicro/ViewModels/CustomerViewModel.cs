using iStockMicro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iStockMicro.ViewModels
{
    public class CustomerViewModel : BaseViewModel
    {
        private List<Customer> _CustomerList         ;
        public List<Customer> CustomerList
        {
            get { return _CustomerList; }
            set
            {
                if (value != this._CustomerList)
                {
                    this._CustomerList = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public List<Customer> GetCustomers()
        {
            CustomerList = new List<Customer>()
            {
                new Customer{customerid = 1, customername = "ThuraTun" , address = "Mandalay"},
                new Customer{customerid = 1, customername = "KaungKyawMoe" , address = "Yangon"},
                new Customer{customerid = 1, customername = "ThanToeAung" , address = "Mandalay"},
                new Customer{customerid = 1, customername = "ThazinMyint" , address = "Yangon"},
                new Customer{customerid = 1, customername = "KhinLayMon" , address = "NayPyiTaw"},
                new Customer{customerid = 1, customername = "ZayarPhyo" , address = "Bago"},
                new Customer{customerid = 1, customername = "KhinNweOo" , address = "Yangon"},
                new Customer{customerid = 1, customername = "KhinSuHlaing" , address = "Yangon"},
                new Customer{customerid = 1, customername = "ThinZar" , address = "Yangon"},
                new Customer{customerid = 1, customername = "KhineWaiZin" , address = "Mandalay"},
                new Customer{customerid = 1, customername = "AyeAye" , address = "Mandalay"},
                new Customer{customerid = 1, customername = "KaungKaung" , address = "Mandalay"},
                new Customer{customerid = 1, customername = "ThantThant" , address = "Mandalay"},
                new Customer{customerid = 1, customername = "ZawZaw" , address = "Mandalay"},
                new Customer{customerid = 1, customername = "MgMg" , address = "Mandalay"}
            };
            return CustomerList;

        }
    }
}
