using Ehealthcare.Entities;
using EHealthcare.Entities;
using Microsoft.EntityFrameworkCore;

namespace ProjectManagement.Data
{
    public class ProjectManagementContext : DbContext
    {
        public ProjectManagementContext(DbContextOptions options) : base(options)
        {

        }

        public void SeedInitialData()
        {
            User testUser1 = new User
            {
                FirstName = "Test",
                LastName = "User1",
                Password = "Password1",
                Email = "testuser1@test.com",
            };
            User adminUser = new User
            {
                FirstName = "Admin",
                LastName = "",
                Password = "Password1",
                Email = "admin@test.com",
                IsAdmin = true
            };

            User.Add(testUser1);
            User.Add(adminUser);

            Product testProduct1 = new Product { Name = "Nutriosys Isabgol", CompanyName = "Company1", Price = 525, ImageUrl = "https://m.media-amazon.com/images/I/51inZITDWAL._AC_UL320_.jpg" };
            Product testProduct2 = new Product {  Name = "Herbocalm Capsules", CompanyName = "Company2", Price = 374, ImageUrl = "https://m.media-amazon.com/images/I/614040xGJKL._AC_UL320_.jpg" };
            Product testProduct3 = new Product {  Name = "Becosules Capsule 20'S", CompanyName = "Company3", Price = 33, ImageUrl = "https://www.netmeds.com/images/product-v1/600x600/341517/becosules_capsule_20_s_0.jpg" };
            Product testProduct4 = new Product {  Name = "Optineuron Injection 3ml ", CompanyName = "Company4", Price = 8, ImageUrl = "https://www.netmeds.com/images/product-v1/600x600/305127/optineuron_injection_3ml_0.jpg" };
            Product testProduct5 = new Product {  Name = "Lacarnit Injection 5ml", CompanyName = "Company4", Price = 110, ImageUrl = "https://www.netmeds.com/images/product-v1/600x600/347820/lacarnit_injection_5ml_0.jpg" };
            Product testProduct6 = new Product {  Name = "Methycobal Injection 1ml", CompanyName = "Company3", Price = 90, ImageUrl = "https://www.netmeds.com/images/product-v1/600x600/330110/methycobal_injection_1ml_0.jpg" };
            Product testProduct7 = new Product {  Name = "Nutritional Powder ", CompanyName = "Company2", Price = 314, ImageUrl = "https://www.netmeds.com/images/product-v1/600x600/889029/pro360_dry_fruits_nutritional_powder_250_gm_0.jpg" };
            Product testProduct8 = new Product {  Name = "Weight Gainer", CompanyName = "Company1", Price = 369, ImageUrl = "https://www.netmeds.com/images/product-v1/600x600/889022/pro360_weight_gainer_nutritional_powder_chocolate_flavour_250_gm_0.jpg" };
            Product testProduct9 = new Product {  Name = "Nutritional Powder", CompanyName = "Company4", Price = 548, ImageUrl = "https://www.netmeds.com/images/product-v1/600x600/889017/pro360_slim_nutritional_powder_choco_vanilla_flavour_500_gm_0.jpg" };

            Product.Add(testProduct1);
            Product.Add(testProduct2);
            Product.Add(testProduct3);
            Product.Add(testProduct4);
            Product.Add(testProduct5);
            Product.Add(testProduct6);
            Product.Add(testProduct7);
            Product.Add(testProduct8);
            Product.Add(testProduct9);
            this.SaveChanges();
        }

        public DbSet<User> User { get; set; }

        public DbSet<Account> Account { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Cart> Cart { get; set; }
        public DbSet<CartItem> CartItem { get; set; }
        public DbSet<Order> Order { get; set; }
    }
}
