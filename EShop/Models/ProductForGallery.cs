using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace EShop.Models
{
    public class ProductForGallery
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public float ProductPrice { get; set; }
        public string ImageName { get; set; }
        /// <summary>
        /// Identificador de la imagen principal
        /// </summary>
        public string ImagePath { get; set; }
    }
}