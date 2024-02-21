// track

using Microsoft.EntityFrameworkCore;

namespace WpfApp3.DB
{
    internal class Sqlite_Context : DbContext
    {
        string _connectionString = "Filename=testSqlite.db";


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(_connectionString);
        }


        public DbSet<User> Users { get; set; }  

    }
}
