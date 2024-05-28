using FinSharkAPI.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace FinSharkAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions dbContextOptions) : base(dbContextOptions) {}

        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Comment> Comments { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    string connstr = @"Server =DESKTOP-UHDTHLN\\SQLEXPRESS;Initial Catalog=Finshark;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        var conn = new SqlConnectionStringBuilder(connstr)
        //        {
        //            ConnectRetryCount = 5,
        //            Pooling = false
        //        };
        //        optionsBuilder.UseSqlServer(conn.ToString(),
        //            options => options.EnableRetryOnFailure());
        //    }
        //    base.OnConfiguring(optionsBuilder);

        //}
    }
}
