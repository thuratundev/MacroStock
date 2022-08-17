using iStockMicro.DataAccess;
using iStockMicro.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace iStockMicro.ViewModels
{
    public class CodeListViewModel : BaseViewModel
    {

        SqlUtilities sqlUtilities;
        public CodeListViewModel()
        {
            sqlUtilities = new SqlUtilities();
        }

        private List<UsrCode> _CodeList;
        public List<UsrCode> CodeList
        {
            get { return _CodeList; }
            set 
            {
                if(value != this._CodeList)
                {
                    this._CodeList = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public async void GetStockList()
        {
            CodeList = await sqlUtilities.GetListAsync<UsrCode>();
        }
    }
}
