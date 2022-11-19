
using ClassMetotDemo;
using System.ComponentModel;

//Customer customer = new Customer();
//customer.customerName = "Yunus";
//customer.customerSurname = "Şahin";
//customer.city = "İstanbul";

//Console.WriteLine(customer.customerName);

//CustomerManager manager = new CustomerManager();
//manager.Add(customer);

Customer customer1 = new Customer();
customer1.customerId = 1;
customer1.customerName = "Yunus";
customer1.customerSurname = "Şahin";
customer1.city = "İstanbul";
customer1.wallet = 10000;

Customer customer2 = new Customer();
customer2.customerId = 2;
customer2.customerName = "Ahmet";
customer2.customerSurname = "Kara";
customer2.city = "İzmir";
customer2.wallet = 9000;

Customer customer3 = new Customer();
customer3.customerId = 3;
customer3.customerName = "Hasan";
customer3.customerSurname = "Kartal";
customer3.city = "Antalya";
customer3.wallet = 7500;

List<Customer> customers = new List<Customer>();  

customers.Add(customer1);   
customers.Add(customer2);   
customers.Add(customer3);

CustomerManager.Listele(customers);





