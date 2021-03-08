using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class Bankcustomer
    {
        public string customerid { get; set; }
        public string customername { get; set; }
        public string customersurname { get; set; }
        public int customerage { get; set; }
        public string customerjob { get; set; }



        public void Ekle(Bankcustomer customers)
        {
            Console.WriteLine("Müşteri Eklendi!");

        }

        public void Sil(Bankcustomer customer)
        {

            Console.WriteLine(customername + "Müşteri Silindi!");

        }

        public void Listele(Bankcustomer customer)
        {

            Console.WriteLine("Hakkında bilgiler listelendi!");

        }
    }
}
