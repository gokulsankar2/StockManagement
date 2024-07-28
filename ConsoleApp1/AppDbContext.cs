using Microsoft.EntityFrameworkCore;
using StockManagement.API.Data.Models;

namespace StockManagement.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<IndividualModel> Individuals { get; set; }
        public DbSet<AccountModel> Accounts { get; set; }
        public DbSet<IndividualTransactionsModel> IndividualTransactions { get; set; }
        public DbSet<StockLogModel> StockLog { get; set; }
        public DbSet<StockModel> Stocks { get; set; }
    }
}
