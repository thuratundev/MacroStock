using iStockMicro.DataAccess;
using iStockMicro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iStockMicro.ViewModels
{
    public class CodeListComponentViewModel : BaseViewModel
    {
        SqlUtilities sqlUtilities;
        public CodeListComponentViewModel()
        {
            sqlUtilities = new SqlUtilities();
            GetStockList();
        }

        private List<UsrCode> _CodeList;
        public List<UsrCode> CodeList
        {
            get { return _CodeList; }
            set
            {
                if (value != this._CodeList)
                {
                    this._CodeList = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private UsrCode _SelectedUsrCode;

        public UsrCode SelectedUsrCode
        {
            get { return _SelectedUsrCode; }
            set 
            {
                if(value != this._SelectedUsrCode)
                {
                    _SelectedUsrCode = value;
                    NotifyPropertyChanged();
                }
               
            }
        }


        private List<Category> _Category;
        public List<Category> Category
        {
            get { return _Category; }
            set 
            {
                if (value != this._Category)
                {
                    this._Category = value;
                    NotifyPropertyChanged();
                }
            }
        }


        public async void GetStockList()
        {

            CodeList = await sqlUtilities.GetListAsync<UsrCode>();
            Category = await sqlUtilities.GetListAsync<Category>();
        }
    }
}
