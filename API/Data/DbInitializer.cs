
using API.Entities;

namespace API.Data
{
    public static class DbInitializer
    {
        public static void Initialize(StoreContext context)
        {
            if (context.Product.Any()) return;

            var products=new List<Product>
            {
                new Product
                {
                    name = "Durian",
                    unitPrice = 100,
                    imageUrl = "https://product.hstatic.net/200000551437/product/monthong_durian___33bdd9b20fa54728ab08711e11521063.png",
                    soldOut = false,
                },
                new Product
                {
                    name = "Mangosteen",
                    unitPrice = 70,
                    imageUrl = "https://assets.stickpng.com/images/5a5f6273ee40df432bfac555.png",
                    soldOut = true,
                },
                new Product
                {
                    name = "Rambutan",
                    unitPrice = 50,
                    imageUrl = "https://www.jctropicals.us/wp-content/uploads/2021/03/jc-tropical-rambutan-fruit.png",
                    soldOut = false,
                },
                new Product
                {
                    name = "Mango",
                    unitPrice = 40,
                    imageUrl = "https://files.oyebesmartest.com/uploads/large/501562050803fuf2mvfr9kto1tk8uagi6tnyb8gfsb0xcwmrfxhsq3pszvyw9mrzkfzzv6gzbxdy7hd4hllwznjlyil6vnywsaswlax2v1fmd2z5.png",
                    soldOut = false,
                },
                new Product
                {
                    name = "Pineapple",
                    unitPrice = 20,
                    imageUrl = "https://pngfre.com/wp-content/uploads/pineapple-74-761x1024.png",
                    soldOut = false,
                },
            };

            foreach (var product in products)
            {
                context.Product.Add(product);
            }
            context.SaveChanges();
        }
    }
}