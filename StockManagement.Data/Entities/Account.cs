using StockManagement.API.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Data.Entities
{
    public class Account : AccountModel
    {
        public virtual Individual Individual { get; set; }
    }
}
