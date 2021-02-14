using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication9.Db
{
    public class MyContext: DbContext
    {
        public const string Schema = "alex";

        public DbSet<MyTable> MyTable { get; set; }

        public MyContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema(Schema);

            base.OnModelCreating(modelBuilder);
        }
    }

    [Table("MyTable1")]
    public class MyTable
    {
        public int Id { get; set; }

        public string Text { get; set; }
    }
}
