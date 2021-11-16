using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace EShop.CORE
{
    /// <summary>
    /// Entidad de dominio de Categoria
    /// </summary>    
    public class Category
    {
        /// <summary>
        /// Identificador de categoria
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nombre de la categoria
        /// </summary>        
        public string CategoryName { get; set; }

		/// <summary>
        /// Descripcion de la categoria
        /// </summary>        
        public string Description { get; set; }
		
		/// <summary>
        /// Imagen de la categoria
        /// </summary>        
        public string Image { get; set; }
       
        /// <summary>
        /// Colección de productos
        /// </summary>
        public virtual List<Product> Products { get; set; }        
    }
}
