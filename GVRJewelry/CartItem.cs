using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVRJewelry
{
   
        public enum JewelryName
        {
            Necklaces,
            Earrings,
            Bangles,

        }
        public enum MaterialName
        {
            Gold,
            Silver,
        }
    public class CartItem

 {
        [Key]
        public int CartItemId { get; set; }

        public int CustomerId { get; set; }
        public JewelryName NameofJewelry { get; set; }
        public MaterialName   NameofMaterial { get; set; }
        public int Quantity { get; set; }
        public double Cost { get; set; }

        public static int previousCartItemId = 1000;
            
            public CartItem()
        {
            CartItemId = previousCartItemId++;
        }
        
          
        }
}
    

