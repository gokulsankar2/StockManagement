using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.API.Data.Models
{
    public class StockModel
    {
        [Key]
        public long StockID { get; set; }

        public long StockLogID { get; set; }

        public decimal PriceOwned { get; set; }

        public decimal AmountOwned { get; set; }
    }
}
