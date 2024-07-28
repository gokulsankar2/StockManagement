using StockManagement.API.Data.Enum;
using System.ComponentModel.DataAnnotations;

namespace StockManagement.API.Data.Models
{
    public class IndividualTransactionsModel
    {
        [Key]
        public long IndividualTransactionID { get; set; }

        public long AccountID { get; set; }

        public long StockID { get; set; }

        public TransactionType TransactionType { get; set; }

        public decimal TransactionAmount { get; set; }

        public DateOnly TransactionDate { get; set; }
    }
}
