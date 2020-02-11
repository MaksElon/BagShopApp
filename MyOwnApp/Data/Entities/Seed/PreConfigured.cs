using Microsoft.AspNetCore.Identity;
using MyOwnApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace MyOwnApp.Data.Entities.Seed
{
    public class PreConfigured
    {
        public static void SeedRoles(RoleManager<Role> roleManager)
        {
            var count = roleManager.Roles.Count();
            if (count <= 0)
            {
                try
                {
                    var roleName = "User";
                    var result = roleManager.CreateAsync(new Role
                    {
                        Name = roleName
                    }).Result;
                    roleName = "Admin";
                    var result2 = roleManager.CreateAsync(new Role
                    {
                        Name = roleName
                    }).Result;
                }
                catch (Exception)
                {

                }
            }
        }
        public static async Task SeedUsers(UserManager<User> userManager, EFContext context)
        {
            var count = userManager.Users.Count();
            if (count <= 0)
            {
                try
                {
                    User user1 = new User
                    {
                        UserName = "ivasuk",
                        Email = "ivasuk@gmail.com",
                        PhoneNumber = "+380503334031",
                        //EmailConfirmed = true,
                        //PhoneNumberConfirmed = true
                    };

                    User user2 = new User
                    {
                        UserName = "admin",
                        Email = "admin@gmail.com",
                        PhoneNumber = "+380507777777",
                        //EmailConfirmed = true,
                        //PhoneNumberConfirmed = true
                    };

                    await userManager.CreateAsync(user1, "Qwerty-1");
                    await userManager.AddToRoleAsync(user1, "Admin");
                    await userManager.CreateAsync(user2, "Qwerty-1");
                    await userManager.AddToRoleAsync(user2, "Admin");
                    await userManager.AddToRoleAsync(user2, "User");

                    UserProfile profile1 = new UserProfile
                    {
                        Id = user1.Id,
                        Address = "Pushkina 44, 12a",
                        CountOfLogins = 0,
                        FirstName = "Ivan",
                        LastName = "Ivanenko",
                        Image = "",
                        RegisterDate = new DateTime(2000, 11, 12)
                    };
                    UserProfile profile2 = new UserProfile
                    {
                        Id = user2.Id,
                        Address = "S.Banderu 44, 12a",
                        CountOfLogins = 0,
                        FirstName = "Semen",
                        LastName = "Semenko",
                        Image = "",
                        RegisterDate = new DateTime(2002, 6, 23)
                    };
                    await context.UserProfiles.AddRangeAsync(profile1, profile2);
                    await context.SaveChangesAsync();
                }
                catch (Exception)
                {

                }
            }
        }
        public static async Task SeedMaterials(EFContext context)
        {
            try
            {
                await context.Materials.AddRangeAsync(new List<Material>{
            new Material
            {
                Name = "Genuine leather"
            },
            new Material
            {
                Name = "Artificial leather"
            },
            new Material
            {
                Name = "Suede"
            }
            });
                await context.SaveChangesAsync();
            }
            catch (Exception)
            {

            }

        }
        public static async Task SeedTypeOfProducts(EFContext context)
        {
            try
            {
                await context.TypeOfProducts.AddRangeAsync(new List<TypeOfProduct>{
            new TypeOfProduct
            {
                Name = "Women"
            },
            new TypeOfProduct
            {
                Name = "Men"
            },
            new TypeOfProduct
            {
                Name = "Kid"
            },
            new TypeOfProduct
            {
                Name="Accessories"
            },
            new TypeOfProduct
            {
                Name="Suitcase"
            }
            });
                await context.SaveChangesAsync();
            }
            catch (Exception)
            {
            }

        }
        public static async Task SeedProducers(EFContext context)
        {
            try
            {
                await context.Producers.AddRangeAsync(new List<Producer>{
            new Producer
            {
                Name = "МІС",
                CapacityAddress="Rivne city, Rabitnichy lane, 5",
                ImageName=""
            }
            });
                await context.SaveChangesAsync();
            }
            catch (Exception)
            {
            }

        }
        public static async Task SeedProductModels(EFContext context)
        {
            try
            {
                await context.ProductModels.AddRangeAsync(new List<ProductModel>{
                new ProductModel
                {
                    Name="Classic bag"
                },
                new ProductModel
                {
                    Name="Purse"
                },
                new ProductModel
                {
                    Name="Tablet bag"
                },
                new ProductModel
                {
                    Name="Theatre bag"
                },
                new ProductModel
                {
                    Name="Clutch"
                }
            });
                await context.SaveChangesAsync();
            }
            catch (Exception)
            {
            }

        }
        public static async Task SeedProductImages(EFContext context, IHostingEnvironment env)
        {
            try
            {
                await context.ProductImages.AddRangeAsync(new List<ProductImage>{
                new ProductImage
                {
                    Name=env.WebRootPath+ @"\images\bag1.jfif",
                    ProductId=1
                },
                new ProductImage
                {
                    Name=env.WebRootPath+ @"\images\bag2.jfif",
                    ProductId=2
                },
                new ProductImage
                {
                    Name=env.WebRootPath+ @"\images\bag3.jfif",
                    ProductId=3
                }
            
            });
                await context.SaveChangesAsync();
            }
            catch (Exception)
            {
            }

        }
        public static async Task SeedDimensions(EFContext context)
        {
            try
            {
                await context.Dimensions.AddRangeAsync(new List<Dimension>{
            new Dimension
            {
                Width=33,
                Height=29,
                BottomWidth=12,
                HandleLength=60,
                ProductId=0
            },
            new Dimension
            {
                Width=30,
                Height=26,
                BottomWidth=14,
                HandleLength=41,
                ProductId=1
            },
            new Dimension
            {
                Width=28,
                Height=21,
                BottomWidth=12,
                HandleLength=43,
                ProductId=3
            }
            });
                await context.SaveChangesAsync();
            }
            catch (Exception)
            {

            }

        }
        public static async Task SeedProducts(EFContext context, IHostingEnvironment env)
        {
                    
            if (!context.Products.Any())
            {
                try
                {
                    if (!context.Materials.Any())
                        await SeedMaterials(context);
                    if (!context.Producers.Any())
                        await SeedProducers(context);
                    if (!context.TypeOfProducts.Any())
                        await SeedTypeOfProducts(context);
                    if (!context.ProductModels.Any())
                        await SeedProductModels(context);

                        Product product1 = new Product
                        {
                            Name = "Women bag MIC - black",
                            Price = 44,
                            SalePercent = 30,
                            Article = "0629",
                            Color = "Black",
                            IsAdvertisingPaid = true,
                            MaterialId = 1,
                            ProducerId = 1,
                            TypeId = 1,
                            ProductModelId = 1
                        };
                    Product product2 = new Product
                    {
                        Name = "Women's suede bag MIS - vinous",
                        Price = 39,
                        SalePercent = 30,
                        Article = "0703",
                        Color = "Vinous",
                        IsAdvertisingPaid = false,
                        MaterialId = 2,
                        ProducerId = 1,
                        TypeId = 1,
                        ProductModelId = 1
                    };
                    Product product3 = new Product
                    {
                        Name = "Women bag MIC black - combined",
                        Price = 48,
                        SalePercent = 10,
                        Article = "35717",
                        Color = "Combined",
                        IsAdvertisingPaid = true,
                        MaterialId = 3,
                        ProducerId = 1,
                        TypeId = 1,
                        ProductModelId = 1
                    };
                    await context.Products.AddRangeAsync(product1, product2, product3);
                    await context.SaveChangesAsync();
                    if (!context.Dimensions.Any())
                        await SeedDimensions(context);
                    if (!context.ProductImages.Any())
                        await SeedProductImages(context, env);
                }
                catch (Exception ex)
                {

                }
            }
        }
    }
}
