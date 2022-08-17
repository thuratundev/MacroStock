using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iStockMicro.Models
{
    [Table("tbl_category")]
    public class Category
    {
        [PrimaryKey, AutoIncrement]
        public int categoryid { get; set; }
        public string categoryname { get; set; }   
    }
}
