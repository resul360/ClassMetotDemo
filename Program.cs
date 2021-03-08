using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //description for product1 
            Bankcustomer customer1 = new Bankcustomer();
            //Musteri bilgileri

            customer1.customerid = "500000212";
            customer1.customername = "Yasin";
            customer1.customersurname = "kaçır";
            customer1.customerage = 27;
            customer1.customerjob = "Mühendis";

            Bankcustomer customer2 = new Bankcustomer();
            //Musteri bilgileri

            customer2.customerid = "5467869988";
            customer2.customername = "Zeynep";
            customer2.customersurname = "Saklı";
            customer2.customerage = 23;
            customer2.customerjob = "Aşcı";

            Bankcustomer customer3 = new Bankcustomer();
            //Musteri bilgileri

            customer3.customerid = "512335468";
            customer3.customername = "Rıza";
            customer3.customersurname = "Emek";
            customer3.customerage = 43;
            customer3.customerjob = "Yazılımcı";


            Bankcustomer[] customers = new Bankcustomer[] { customer1, customer2, customer3 };

            foreach (var cust in customers)
            {
                Console.WriteLine("Id: " + cust.customerid);
                Console.WriteLine("Name: " + cust.customername);
                Console.WriteLine("Surname: " + cust.customersurname);
                Console.WriteLine("Age: " + cust.customerage);
                Console.WriteLine("Job: " + cust.customerjob);
                Console.WriteLine("--------------------------");
            }
            Bankcustomer custo = new Bankcustomer();

            Console.WriteLine(customer1.customername + " Adında");
            custo.Ekle(customer1);
            Console.WriteLine("--------------------------");

            custo.Sil(customer3);
            Console.WriteLine("--------------------------");

            custo.Listele(customer2);

        }
    }
    
}