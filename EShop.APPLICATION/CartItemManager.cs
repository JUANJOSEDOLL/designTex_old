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
    /// Clase manager de CartItem
    /// </summary>
    public class CartItemManager : GenericManager<CartItem> //, ICartItemManager
    {
        /// <summary>
        /// Constructor de la clase Manager de CartItem
        /// </summary>
        /// <param name="context">Contexto de datos</param>
        public CartItemManager(ApplicationDbContext context) : base(context)
        {
        }

        /// <summary>
        /// Método que retorna todos los items del carrito
        /// </summary>

        public IQueryable<CartItem> GetTodos()
        {
            return Context.Set<CartItem>();
        }

        /// <summary>
        /// Método que retorna todos los items de la sesion actual
        /// </summary>
        /// <param name="CartId">Identificador de la sesion</param>
        /// <returns>Retorna los items que cumplen el filtro </returns>
        public IQueryable<CartItem> GetByCartId(string ParameterCartId)
        {
            return Context.Set<CartItem>().Where(e => e.CartId == ParameterCartId);
        }

    }
}
