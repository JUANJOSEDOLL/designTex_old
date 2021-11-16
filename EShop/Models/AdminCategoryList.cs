using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EShop.Models
{
    public class AdminCategoryList
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



    }
}