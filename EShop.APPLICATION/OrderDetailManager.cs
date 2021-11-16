using EShop.CORE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShop.DAL;


namespace EShop.APPLICATION
{
    /// <summary>
    /// Clase manager de OrderDetail
    /// </summary>
    public class OrderDetailManager : GenericManager<OrderDetail> //, IOrderDetailManager
    {
        /// <summary>
        /// Constructor de la clase Manager de OrderDetail
        /// </summary>
        /// <param name="context">Contexto de datos</param>
        public OrderDetailManager(ApplicationDbContext context) : base(context)
        {
        }

       
    }
}
