using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVRJewelry
{
    class Store
    {
        JewelryModel jdb = new JewelryModel();

        public int CreatenewCustomer(string customerName, string customerAddress)
        {
            
            Customer myCustomer = new Customer()
            {

                CustomerName = customerName,
                CustomerAddress = customerAddress,
            };

            jdb.Customers.Add(myCustomer);
            jdb.SaveChanges();

            Console.WriteLine("Customer{0},{1}", customerName, customerAddress);

            return myCustomer.CustomerId;
        }
        public void AddToCart(int customerId, JewelryName nameofJewelry, 
            MaterialName nameofMaterail, int quantity, double cost)
        {
            CartItem myCartItem = new CartItem()

            {

                CustomerId = customerId,
            NameofJewelry = nameofJewelry,
            NameofMaterial = nameofMaterail,
            Quantity = quantity,
            Cost = cost,

        };
        jdb.CartItems.Add(myCartItem);
        Console.WriteLine("/n Your Jewelry is added Successfully");
            jdb.SaveChanges();
    
        }



        
    }
}
