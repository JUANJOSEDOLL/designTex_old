using EShop.CORE;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.DAL
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        /// <summary>
        /// Colección persistible de incidencias
        /// </summary>
        public DbSet<Category> Categories { get; set; }

        /// <summary>
        /// Colección persistible de mensajes
        /// </summary>
        public DbSet<Image> Images { get; set; }

        /// <summary>
        /// Colección persistible de incidencias
        /// </summary>
        public DbSet<Order> Orders { get; set; }

        /// <summary>
        /// Colección persistible de mensajes
        /// </summary>
        public DbSet<OrderDetail> OrderDetails { get; set; }

        /// <summary>
        /// Colección persistible de mensajes
        /// </summary>
        public DbSet<Product> Products { get; set; }

        /// <summary>
        /// Colección persistible de items de carrito
        /// </summary>

        public DbSet<CartItem> CartItems { get; set; }

    }
}
