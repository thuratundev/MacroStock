using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iStockMicro.Models
{

    [Table("tbl_usrcode")]
    public class UsrCode
    {
        [PrimaryKey,NotNull]
        public string usrcode { get; set; }

        public string description { get; set; }

        public decimal? saleprice { get; set; }

        public int? categoryId { get; set; }
    }
}
