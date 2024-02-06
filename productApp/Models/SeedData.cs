using Microsoft.EntityFrameworkCore;
using productApp.Data.Enums;
using productApp.Data;
using System;
using System.Linq;

namespace productApp.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new Data.productAppContext(
                serviceProvider.GetRequiredService<DbContextOptions<productAppContext>>());


            context.Database.EnsureCreated();

            // Entreprise
            if (!context.Entreprise.Any())
            {
                context.Entreprise.AddRange(new List<Entreprise>()
                    {
                        new Entreprise()
                        {
                            EntrepriseLogoURL = "https://www.colt.net/wp-content/uploads/2021/09/Decathlon-Logo.png",
                            NomEntreprise = "DECATHLON",
                            Discription = "Decathlon is a French sporting goods retailer. With over 2,080 stores in 56 countries and regions (2023), it is the largest sporting goods retailer in the world."
                        },
                        new Entreprise()
                        {
                            EntrepriseLogoURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0c/Under_Armour_Logo.svg/1200px-Under_Armour_Logo.svg.png",
                            NomEntreprise = "Under Armour, Inc.",
                            Discription = "Under Armour, Inc. is an American company that manufactures footwear, sports, and casual apparel. Under Armour's global headquarters are located in Baltimore, Maryland with additional North American corporate office locations in Austin and Houston, Texas; Denver, Colorado; New York City; and Portland, Oregon."
                        },
                        new Entreprise()
                        {
                            EntrepriseLogoURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a6/Logo_NIKE.svg/1200px-Logo_NIKE.svg.png",
                            NomEntreprise = "Nike, Inc.",
                            Discription = "Nike, Inc. is an American multinational corporation that is engaged in the design, development, manufacturing, and worldwide marketing and sales of footwear, apparel, equipment, accessories, and services."
                        },
                        new Entreprise()
                        {
                            EntrepriseLogoURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/85/Puma_logo.svg/1200px-Puma_logo.svg.png",
                            NomEntreprise = "Puma SE",
                            Discription = "Puma SE is a German multinational corporation that designs and manufactures athletic and casual footwear, apparel and accessories, which is headquartered in Herzogenaurach, Bavaria, Germany. Puma is the third largest sportswear manufacturer in the world."
                        },
                        new Entreprise()
                        {
                            EntrepriseLogoURL = "https://upload.wikimedia.org/wikipedia/commons/f/fa/Apple_logo_black.svg",
                            NomEntreprise = "Apple Inc.",
                            Discription = "Apple Inc. is an American multinational technology company that designs, develops, and sells consumer electronics, computer software, and online services. The company's hardware products include the iPhone smartphone, the iPad tablet computer, the Mac personal computer, the iPod portable media player, the Apple Watch smartwatch, the Apple TV digital media player, the AirPods wireless earbuds and the HomePod smart speaker."
                        },
                        new Entreprise()
                        {
                            EntrepriseLogoURL = "https://upload.wikimedia.org/wikipedia/commons/1/13/Samsung_logo.svg",
                            NomEntreprise = "Samsung Electronics Co., Ltd.",
                            Discription = "Samsung Electronics Co., Ltd. is a South Korean multinational electronics company headquartered in the Yeongtong District of Suwon. It is the world's largest manufacturer of consumer electronics by revenue."
                        },
                        new Entreprise()
                        {
                            EntrepriseLogoURL = "https://upload.wikimedia.org/wikipedia/commons/6/6c/Sony_logo.svg",
                            NomEntreprise = "Sony Corporation",
                            Discription = "Sony Corporation is a Japanese multinational conglomerate corporation headquartered in Kōnan, Minato, Tokyo. The company operates as one of the world's largest manufacturers of consumer and professional electronic products, the largest video game console company, the second largest video game publisher, the second largest record company, as well as one of the most comprehensive media companies, being the largest Japanese media conglomerate by size overtaking the privately held, family-owned Yomiuri Shimbun Holdings, the largest Japanese media conglomerate by revenue."
                        }
                    });
                context.SaveChanges();
            }

            // Products
            if (!context.Product.Any())
            {
                context.Product.AddRange(new List<Product>()
                    {
                        new Product()
                        {
                            Name = "Kalenji Run Cushion Men's Running Shoes",
                            Description = "The Kalenji Run Cushion Men's Running Shoes are designed for road running and provide optimal cushioning and comfort for runners of all levels.",
                            Price = 39.99,
                            ImageURL = "https://contents.mediadecathlon.com/p1860325/k$52076a0a4e38b3fe1de036d2704ecb86/men-s-running-shoes-run-cushion-black-white.jpg?&f=250x250",
                            ReleaseDate = DateTime.Now,
                            ProductCategory = ProductCategory.Sports,
                            EntrepriseId = 1
                        },
                        new Product()
                        {
                            Name = "Van Rysel Aerofit 900 Road Cycling Helmet",
                            Description = "The Van Rysel Aerofit 900 Road Cycling Helmet is designed for road cyclists seeking a lightweight and aerodynamic helmet with excellent ventilation and comfort.",
                            Price = 69.99,
                            ImageURL = "https://contents.mediadecathlon.com/p1881728/k$f0cdad7f4e4f091df43422a8f61dc460/van-rysel-aerofit-900-road-cycling-helmet-navy-blue.jpg?&f=250x250",
                            ReleaseDate = DateTime.Now,
                            ProductCategory = ProductCategory.Sports,
                            EntrepriseId = 1
                        },
                        new Product()
                        {
                            Name = "Artengo TR160 Lite Adult Tennis Racket",
                            Description = "The Artengo TR160 Lite Adult Tennis Racket is perfect for beginner to intermediate tennis players looking for a lightweight and maneuverable racket with excellent control and comfort.",
                            Price = 29.99,
                            ImageURL = "https://contents.mediadecathlon.com/p1944292/k$9d4d9f5a9327892fb9be8e10048bfcf9/artengo-tr160-lite-adult-tennis-racket-blue.jpg?&f=250x250",
                            ReleaseDate = DateTime.Now,
                            ProductCategory = ProductCategory.Sports,
                            EntrepriseId = 1
                        },
                        new Product()
                        {
                            Name = "Domyos Essential Yoga Mat 8mm",
                            Description = "The Domyos Essential Yoga Mat 8mm is perfect for all types of yoga practices, providing excellent cushioning and stability for your workouts.",
                            Price = 24.99,
                            ImageURL = "https://contents.mediadecathlon.com/p1608952/k$168ef7c9e7c22fa996c208e57354a037/essential-yoga-mat-8-mm-green.jpg?&f=250x250",
                            ReleaseDate = DateTime.Now,
                            ProductCategory = ProductCategory.Sports,
                            EntrepriseId = 1
                        },
                        new Product()
                        {
                            Name = "Nabaiji Xbase Swimming Goggles",
                            Description = "The Nabaiji Xbase Swimming Goggles are designed for regular swimmers looking for comfortable and fog-free goggles with a wide field of vision.",
                            Price = 9.99,
                            ImageURL = "https://contents.mediadecathlon.com/p1871621/k$8273de33b88b05f871ef1344f52a9bc9/xbase-swimming-goggles-blue-green.jpg?&f=250x250",
                            ReleaseDate = DateTime.Now,
                            ProductCategory = ProductCategory.Sports,
                            EntrepriseId = 1
                        },
                        new Product()
                        {
                            Name = "Samsung Galaxy S21 Ultra 5G",
                            Description = "The Samsung Galaxy S21 Ultra 5G is a flagship smartphone featuring a stunning 6.8-inch Dynamic AMOLED display, a versatile quad-camera system, and powerful performance with 5G connectivity.",
                            Price = 1199.99,
                            ImageURL = "https://cdn2.gsmarena.com/vv/bigpic/samsung-galaxy-s21-ultra-5g.jpg",
                            ReleaseDate = new DateTime(2021, 1, 29),
                            ProductCategory = ProductCategory.Electronics,
                            EntrepriseId = 5
                        },
                        new Product()
                        {
                            Name = "Samsung QN90A Neo QLED 4K Smart TV",
                            Description = "The Samsung QN90A Neo QLED 4K Smart TV delivers stunning picture quality with Quantum Matrix Technology, vibrant colors, and immersive sound, providing an unparalleled viewing experience.",
                            Price = 2999.99,
                            ImageURL = "https://www.samsung.com/us/explore/qled-tv/assets/images/hero-q90a.png",
                            ReleaseDate = new DateTime(2021, 3, 15),
                            ProductCategory = ProductCategory.Electronics,
                            EntrepriseId = 5
                        },
                        new Product()
                        {
                            Name = "Samsung Odyssey G7 Gaming Monitor",
                            Description = "The Samsung Odyssey G7 Gaming Monitor is a high-performance gaming monitor with a curved QLED display, fast refresh rate, and immersive gaming features for competitive gamers.",
                            Price = 699.99,
                            ImageURL = "https://images.samsung.com/is/image/samsung/p6pim/uk/lc32g77tqsmxue/gallery/uk-gaming-monitor-g7-lc32g77tqsmxue-363669-351277-Silver-02-3200x1800.jpg?$PD_GALLERY_L_JPG$",
                            ReleaseDate = new DateTime(2020, 7, 22),
                            ProductCategory = ProductCategory.Electronics,
                            EntrepriseId = 5
                        },
                        new Product()
                        {
                            Name = "Samsung T7 Portable SSD",
                            Description = "The Samsung T7 Portable SSD offers lightning-fast transfer speeds, robust security features, and a compact, durable design, making it perfect for on-the-go storage and data transfer.",
                            Price = 149.99,
                            ImageURL = "https://images.samsung.com/is/image/samsung/levant-portable-ssd-t7-touch-mu-pc1t0b-ka?imwidth=1600",
                            ReleaseDate = new DateTime(2020, 2, 12),
                            ProductCategory = ProductCategory.Electronics,
                            EntrepriseId = 5
                        }

                    });
                context.SaveChanges();
            }
        }
    }
}
