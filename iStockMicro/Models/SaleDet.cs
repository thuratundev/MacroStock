using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iStockMicro.Models
{
    [Table("tbl_saledet")]
    public class SaleDet
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public Guid tranid { get; set; }
        public int srno { get; set; }
        public string usrcode { get; set; }
         
        [Ignore]
        public string description { get; set; }
        public int? unitqty { get; set; }
        public decimal? saleprice { get; set; }
    }
}
