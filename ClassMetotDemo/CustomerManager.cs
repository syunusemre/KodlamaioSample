using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    public class CustomerManager
    {
        public static void Add(List<Customer> list, Customer customer)
        {
            list.Add(customer);
        }
        public static void Remove(List<Customer> list, Customer customer)
        {
            list.Remove(customer);
        }
        public static void Listele(List<Customer> customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine(" ID:" + customer.customerId + " name: " + customer.customerName + "  Surname: " + customer.customerSurname + " City: " + customer.city + " Bakiye: " + customer.wallet + "TL" + customer.customerSurname);
            }
        }

        //    public void Add(Customer customer)
        //{
        //    Console.WriteLine("kullanici adi: " + customer.customerName);
        //    Console.WriteLine("kullanici Soyadı: " + customer.customerSurname);
        //    Console.WriteLine("Şehri: " + customer.city);
        //}
    }
}
