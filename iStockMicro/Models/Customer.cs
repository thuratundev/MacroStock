using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iStockMicro.Models
{
    [Table("tbl_customer")]
    public class Customer
    {
        [PrimaryKey, AutoIncrement]
        public int customerid { get; set; }
        public string customername { get; set; }
        public string address { get; set; }
    }
}
