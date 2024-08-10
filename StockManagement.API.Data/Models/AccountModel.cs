using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.API.Data.Models
{
    public class AccountModel
    {
        [Key]
        public long AccountID { get; set; }

        public long IndividualID { get; set; }

        public DateOnly DateCreated { get; set; }
    }
}
