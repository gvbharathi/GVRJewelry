using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVRJewelry
{
    public static class Store
    {
        static JewelryModel jdb = new JewelryModel();
        public static Customer FindCustomer(string customerEmail)
        {
            return jdb.Customers.Where(k=>k.CustomerEmail==customerEmail)
                .FirstOrDefault();
        }

        public static int CreatenewCustomer(string customerName, string customerAddress,string customerEmail)
        {
            
            Customer myCustomer = new Customer()
            {

                CustomerName = customerName,
                CustomerAddress=customerAddress,
                CustomerEmail=customerEmail
                
                
            };

            jdb.Customers.Add(myCustomer);
            jdb.SaveChanges();

            Console.WriteLine("Customer{0},{1},{2}", customerName, customerAddress,customerEmail);

            return myCustomer.CustomerId;
        }
        public static void AddToCart(int customerId, JewelryName nameofJewelry, 
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
        }
              public static void ViewCart()
            {
              foreach(CartItem Item in jdb.CartItems)
                {
                Console.WriteLine("\n CustomerId:{0},NameofJewelry:{1},NameofMaterial:{2},Quantity:{3},Cost:{4}",
                     Item.CustomerId, Item.NameofJewelry, Item.NameofMaterial, Item.Quantity, Item.Cost);

                                
                           
                }
            }

        //public void ViewCart()
        //{
        //    foreach (CartItem item in jdb.CartItems)
        //    {
        //        Console.WriteLine("CustomerId" + item.CustomerId +
        //            "Name of Jewelry" + item.NameofJewelry +
        //            "qty" + item.Quantity +
        //            "cost" + item.Cost
        //            );
        //    }
        //}
     
    }
       


}


        
    

