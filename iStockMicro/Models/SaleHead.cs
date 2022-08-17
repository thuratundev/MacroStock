using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iStockMicro.Models
{
    [Table("tbl_salehead")]
    public class SaleHead
    {
        [PrimaryKey]
        public Guid tranid { get; set; }
        public DateTime? date { get; set; }
        public int? customerid { get; set; }

        [Ignore]
        public string customername { get; set; }
        public string invoiceno { get; set; }
    }
}
