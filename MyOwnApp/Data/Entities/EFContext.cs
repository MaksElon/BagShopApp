using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyOwnApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOwnApp.Data.Entities
{
    public class EFContext : IdentityDbContext<User, Role, string, IdentityUserClaim<string>,
    UserRole, IdentityUserLogin<string>,
    IdentityRoleClaim<string>, IdentityUserToken<string>>
    {
        public EFContext(DbContextOptions<EFContext> options) : base(options)
        {

        }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductImage> ProductImages { get; set; }
        public virtual DbSet<TypeOfProduct> TypeOfProducts { get; set; }
        public virtual DbSet<Producer> Producers { get; set; }
        public virtual DbSet<Material> Materials { get; set; }
        public virtual DbSet<ProductModel> ProductModels { get; set; }
        public virtual DbSet<UserProfile> UserProfiles { get; set; }
        public virtual DbSet<Dimension> Dimensions { get; set; }
        public virtual DbSet<ProductOrder> ProductOrders { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<SubCategory> SubCategories { get; set; }
        public virtual DbSet<Likes> Likes { get; set; }
        public virtual DbSet<Dislikes> Dislikes { get; set; }
        public virtual DbSet<FileModel> FileModels { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ProductOrder>()
                .HasKey(bc => new { bc.OrderId, bc.ProductId });
            builder.Entity<ProductOrder>()
                .HasOne(p => p.ProductOf)
                .WithMany(po => po.ProductOrders)
                .HasForeignKey(p => p.ProductId);
            builder.Entity<ProductOrder>()
                .HasOne(p => p.OrderOf)
                .WithMany(po => po.ProductOrders)
                .HasForeignKey(p => p.OrderId);


            builder.Entity<UserRole>(userRole =>
            {
                userRole.HasKey(ur => new { ur.UserId, ur.RoleId });


                userRole.HasOne(ur => ur.Role)
                    .WithMany(r => r.UserRoles)
                    .HasForeignKey(ur => ur.RoleId)
                    .IsRequired();



                userRole.HasOne(ur => ur.User)
                    .WithMany(r => r.UserRoles)
                    .HasForeignKey(ur => ur.UserId)
                    .IsRequired();
            });
        }
    }
    //public class EFContext : DbContext
    //{
    //    public EFContext(DbContextOptions<EFContext> options) : base(options)
    //    {

    //    }

    //    public virtual DbSet<Product> Products { get; set; }
    //    public virtual DbSet<ProductImage> ProductImages { get; set; }
    //    public virtual DbSet<TypeOfProduct> TypeOfProducts { get; set; }
    //    public virtual DbSet<Producer> Producers { get; set; }
    //    public virtual DbSet<Material> Materials { get; set; }
    //    public virtual DbSet<ProductModel> ProductModels { get; set; }
    //    public virtual DbSet<User> Users { get; set; }
    //    public virtual DbSet<Dimension> Dimensions { get; set; }

    //}
}
