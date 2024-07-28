using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.API.Data.Models
{
    public class StockLogModel
    {
        [Key]
        public long StockLogID { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Code { get; set; }

        public string? Industry { get; set; }
    }
}
