using iStockMicro.DataAccess;
using iStockMicro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iStockMicro.ViewModels
{
    internal class CategoryListViewModel : BaseViewModel
    {
        SqlUtilities sqlUtilities;

        public CategoryListViewModel()
        {
            sqlUtilities = new SqlUtilities();
        }

        private List<Category> _CategoryList;
        public List<Category> CategoryList
        {
            get { return _CategoryList; }
            set
            {
                if (value != this._CategoryList)
                {
                    this._CategoryList = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public async void GetStockList()
        {
            CategoryList = await sqlUtilities.GetListAsync<Category>();
        }

    }
}
