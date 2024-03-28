using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concretes.EntityFramework
{
    // Veritabanını temsil eden dosya
    public class BaseDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        
        


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=OMER\\SQLEXPRESS;Initial Catalog=Tobeto4a1;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Category category = new Category() { Id=3, Name = "Elektronik" ,Description ="Elektronik eşyalar" };
            Category category1 = new Category() {Id=4, Name = "Temizlik " ,Description ="arap sabunu" };
            Brand brand = new Brand() {Id=5, Name = "Apple" };
            Product product = new Product() { Id = 4, Name = "Iphone15",Brand=new() {Id=5 } };

            modelBuilder.Entity<Category>().HasData(category,category1);
            modelBuilder.Entity<Brand>().HasData(brand);
            modelBuilder.Entity<Product>().HasData(product);

            base.OnModelCreating(modelBuilder);
        }
    }
}
