using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVRJewelry
{
    class Program
    {

       // Store myStore = new Store();
        public static  void Main(string[] args)
        {




            //// Jewelry  myJewelry;
            JewelryName myJewelryName = JewelryName.Necklaces;
            MaterialName myJewelryMaterialName = MaterialName.Gold;
           
            var option = "1";

            Console.WriteLine("*************Welcome To SamJewelry**********");

            


            do

            {
                Console.WriteLine("Please select one of the Options below");
                Console.WriteLine("1.Create new Jewelry");
                Console.WriteLine("2.View Cart");
                Console.WriteLine("3. Remove from the Cart");
                Console.WriteLine("4.Exit");


                option = Console.ReadLine();

                switch (option)
                {
                    // Create Jewelry
                    case "1":
                        Console.WriteLine("\nSelection the Jewerly Name");
                        Console.WriteLine("1 - Neckles");
                        Console.WriteLine("2 - Bangles");
                        Console.WriteLine("3 - EarRings");

                        var JewelryNameOption = Console.ReadLine();


                        switch (JewelryNameOption)
                        {
                            case "2":
                                myJewelryName = JewelryName.Bangles;
                                break;
                            case "3":
                                myJewelryName = JewelryName.Earrings;
                                break;
                        }

                        Console.WriteLine("\nSelect Material Type");
                        Console.WriteLine("1- Gold");
                        Console.WriteLine("2 - Silver");

                        var JewerlyMaterialOption = Console.ReadLine();

                        switch (JewerlyMaterialOption)
                        {
                            case "2":
                                myJewelryMaterialName = MaterialName.Silver;
                                break;

                        }

                        Console.WriteLine("\nEnter Quantity");

                        var myJewelryQuantity = int.Parse(Console.ReadLine());


                        Store.AddToCart(myCustomerId, myJewelryName, myJewelryMaterialName, myJewelryQuantity, 20000);


                        break;
                    //View Cart

                    case "2":
                       // ICollection<string> CartItems = new List<string>();
                        Store.ViewCart();
                        break;
                    case "3":
                        // myStore.Remove(myCustomerId, myJewelryName, myJewelryMaterialName, myJewelryQuantity, 20000);
                        {

                        }
                        break;

                }
            } while (option != "4");
        

                return ;
            }
        }

    }


    
    




        