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
    /// Clase manager de Category
    /// </summary>
    public class CategoryManager : GenericManager<Category>  //, ICategoryManager
    {
        /// <summary>
        /// Constructor de la clase Manager de Category
        /// </summary>
        /// <param name="context">Contexto de datos</param>
        public CategoryManager(ApplicationDbContext context) : base(context)
        {
        }

        /// <summary>
        /// Método que retorna todos las categorias
        /// </summary>
        /// <returns>Todas las categorias</returns>
        public IQueryable<Category> GetAll2()
        {
            return Context.Set<Category>();
        }

        /// <summary>
        /// Obtiene una categoria con sus productos
        /// </summary>
        /// <param name="id">Identificador de la categoria</param>
        /// <returns>Categoria con sus productos si existen o null en caso de no existir</returns>
        public Category GetByCategoryIdtheirProducts(int id)
        {
            return Context.Set<Category>().Include("Products").Where(i => i.Id == id).SingleOrDefault();
        }
    }
}
