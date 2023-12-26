namespace skyline.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CartItem>()
                .HasKey(ci => new { ci.UserId, ci.ProductId, ci.ProductTypeId });

            modelBuilder.Entity<ProductVariant>()
                .HasKey(p => new { p.ProductId, p.ProductTypeId });

            modelBuilder.Entity<OrderItem>()
                .HasKey(oi => new { oi.OrderId, oi.ProductId, oi.ProductTypeId });


            modelBuilder.Entity<ProductType>().HasData(
                    new ProductType
                    {
                        Id = 1,
                        Name = "Raythos C-320",
                        Description = "A state-of-the-art commercial jet designed for efficiency and comfort.",
                        BasePrice = 90000000M,
                        ImageUrl = "https://example.com/images/raythos-c320.jpg",
                        Specifications = "Capacity: 150-180 passengers, Range: 5,000 nautical miles, Cruise Speed: 560 mph"
                    },
                    new ProductType
                    {
                        Id = 2,
                        Name = "Raythos P-200",
                        Description = "Luxurious and high-performing, perfect for business or leisure travel.",
                        BasePrice = 40000000M,
                        ImageUrl = "https://example.com/images/raythos-p200.jpg",
                        Specifications = "Capacity: 8-12 passengers, Range: 3,000 nautical miles, Cruise Speed: 600 mph"
                    },
                    new ProductType
                    {
                        Id = 3,
                        Name = "Raythos Cargomaster 500",
                        Description = "Designed for cargo transport, offering an optimal balance of payload capacity and efficiency.",
                        BasePrice = 70000000M,
                        ImageUrl = "https://example.com/images/cargomaster500.jpg",
                        Specifications = "Payload: 50,000 kg, Range: 4,000 nautical miles, Cargo Volume: 400 m³"
                    }
                );

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Commercial Aircraft",
                    Url = "/categories/commercial-aircraft",
                    Visible = true,
                    Deleted = false
                },
                new Category
                {
                    Id = 2,
                    Name = "Private Jets",
                    Url = "/categories/private-jets",
                    Visible = true,
                    Deleted = false
                },
                new Category
                {
                    Id = 3,
                    Name = "Cargo Planes",
                    Url = "/categories/cargo-planes",
                    Visible = true,
                    Deleted = false
                }
                );

            modelBuilder.Entity<Product>().HasData(
                    new Product
                    {
                        Id = 1,
                        Title = "Raythos C-320 Jet",
                        Description = "A versatile commercial jet",
                        ImageUrl = "https://example.com/main-image.jpg",
                        Images = new List<Image> (),
                        CategoryId = 1,
                        Featured = true,
                        Variants = new List<ProductVariant>(),
                        Visible = true,
                        Deleted = false
                    },
                    new Product
                    {
                        Id = 2,
                        Title = "Raythos Light Jet X200",
                        Description = "A sleek and efficient light jet, perfect for quick business trips.",
                        ImageUrl = "https://example.com/lightjet-main.jpg",
                        Images = new List<Image> (),
                        CategoryId = 2,
                        Featured = false,
                        Variants = new List<ProductVariant>(),
                        Visible = true,
                        Deleted = false
                    },
                    new Product
                    {
                        Id = 3,
                        Title = "Raythos Midsize Jet M500",
                        Description = "Spacious and luxurious, ideal for longer journeys and larger groups.",
                        ImageUrl = "https://example.com/midsizejet-main.jpg",
                        Images = new List<Image> (),
                        CategoryId = 2,
                        Featured = true,
                        Variants = new List<ProductVariant>(),
                        Visible = true,
                        Deleted = false
                    }

                    );

            modelBuilder.Entity<ProductVariant>().HasData(
                new ProductVariant
                {
                    ProductId =1,
                    ProductTypeId = 1,
                    Price = 90000000M,
                    OriginalPrice = 95000000M,
                    Visible = true,
                    Deleted = false
                },
                new ProductVariant
                {
                    ProductId = 1,
                    ProductTypeId = 2,
                    Price = 80000000M,
                    OriginalPrice = 85000000M,
                    Visible = true,
                    Deleted = false
                },
                new ProductVariant
                {
                    ProductId =2,
                    ProductTypeId = 1,
                    Price = 90000000M,
                    OriginalPrice = 95000000M,
                    Visible = true,
                    Deleted = false
                },
                new ProductVariant
                {
                    ProductId = 2,
                    ProductTypeId = 2,
                    Price = 80000000M,
                    OriginalPrice = 85000000M,
                    Visible = true,
                    Deleted = false
                },
                new ProductVariant
                {
                    ProductId =3,
                    ProductTypeId = 3,
                    Price = 90000000M,
                    OriginalPrice = 95000000M,
                    Visible = true,
                    Deleted = false
                },
                new ProductVariant
                {
                    ProductId = 3,
                    ProductTypeId = 2,
                    Price = 80000000M,
                    OriginalPrice = 85000000M,
                    Visible = true,
                    Deleted = false
                }
            );
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<ProductVariant> ProductVariants { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Image> Images { get; set; }
    }
}
