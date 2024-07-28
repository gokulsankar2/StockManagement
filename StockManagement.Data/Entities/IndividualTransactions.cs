using StockManagement.API.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.Data.Entities
{
    public class IndividualTransactions : IndividualTransactionsModel
    {
        public virtual Account Account { get; set; }

        public virtual Stock Stock { get; set; }
    }
}
