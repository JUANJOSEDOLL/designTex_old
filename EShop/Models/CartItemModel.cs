using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using EShop.CORE;

namespace EShop.Models
{
    public class CartItemModel
    {
        
        public int Id { get; set; }

        public string CartId { get; set; }

        public int Quantity { get; set; }
                     
        public string ProductName { get; set; }
                
        public float ProductPrice { get; set; }

        public System.DateTime DateCreated { get; set; }
            
        public int Product_Id { get; set; }

    }
}