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
    /// Clase manager de Order
    /// </summary>
    public class OrderManager : GenericManager<Order> //, IOrderManager
    {
        /// <summary>
        /// Constructor de la clase Manager de Order
        /// </summary>
        /// <param name="context">Contexto de datos</param>
        public OrderManager(ApplicationDbContext context) : base(context)
        {
        }

        /// <summary>
        /// Método que retorna todas las Ordenes o pedidos de un usuario
        /// </summary>
        /// <param name="userId">Identificador de usuario</param>
        /// <returns>Todas las Ordenes o pedidos de usuario</returns>
        public IQueryable<Order> GetByUserId(string userId)
        {
            return Context.Set<Order>().Where(e => e.User_Id == userId);
        }


        /// <summary>
        /// Método que retorna todas las Ordenes
        /// </summary>
       
        public IQueryable<Order> GetTodo()
            {
            return Context.Set<Order>();
            }


        /// <summary>
        /// Obtiene una orden con sus líneas de  pedidos
        /// </summary>
        /// <param name="id">Identificador de la orden</param>
        /// <returns>Orden con sus líneas de  pedidos si existe o null en caso de no existir</returns>
        public Order GetByIdAndOrderDetails(int id)
        {
            return Context.Set<Order>().Include("OrderDetails").Where(i => i.Id == id).SingleOrDefault();
        }
    }
}
