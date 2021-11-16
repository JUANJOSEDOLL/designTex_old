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
    /// Clase manager de Imágenes
    /// </summary>
    public class ImageManager : GenericManager<Image> //, IImageManager
    {
        /// <summary>
        /// Constructor de la clase Manager de Imagen
        /// </summary>
        /// <param name="context">Contexto de datos</param>
        public ImageManager(ApplicationDbContext context) : base(context)
        {
        }

        /// <summary>
        /// Método que retorna todas los Imagenes
        /// </summary>

        public IQueryable<Image> GetTodos()
        {
            return Context.Set<Image>();
        }

        /// <summary>
        /// Método que retorna todas las Imagenes de un producto
        /// </summary>
        /// <param name="ProductId">Identificador de producto</param>
        /// <returns>Todos las Imagenes de una imagen </returns>
        public IQueryable<Image> GetByProductId(int ProductId)
        {
            return Context.Set<Image>().Where(e => e.Product_Id == ProductId);
        }

        /// <summary>
        /// Retorna la primera imagen del producto
        /// En principio no se va a utilizar, pues se declara una imagen principal en la
        /// tupla del producto y una tabla a nivel de objeto un array, donde se guardan 
        /// el resto de las imágenes
        /// </summary>
        /// <param name="ProductId">Identificador del producto</param>
        /// <returns>Primera imagen del producto</returns>
        public Image GetFirstImage(int ProductId)
        {
            return Context.Images.Where(m => m.Product_Id == ProductId).OrderBy(i => i.Product_Id).FirstOrDefault();

        }

      

    }
}

