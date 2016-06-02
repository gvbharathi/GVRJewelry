using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVRJewelry
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string CustomerName{get; set;}
        public string  CustomerEmail { get; set; }
        public string CustomerAddress { get; set; }
 
        public virtual ICollection<CartItem> CartItems { get; set; }

        public int previousCustomerId = 0;
       

        public Customer()
        {
            CustomerId = previousCustomerId++;
        }

    }
}
