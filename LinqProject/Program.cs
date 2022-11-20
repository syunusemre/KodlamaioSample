namespace LinqProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kategori listesi oluşturma

            List<Category> list = new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Bilgisayar" },
                new Category{CategoryId=2, CategoryName="Telefon" },
            };

            //product içerisine listeleme şeklinde yeni product oluşturma
            List<Product> products = new List<Product>
            {
                new Product{ProductId=1, CategoryId=1, ProductName="Acer Laptop",QuantityPerUnit="16 GB Ram",UnitPrice=10000,UnitsInStock=5},
                new Product{ProductId=2, CategoryId=1, ProductName="Monster Laptop",QuantityPerUnit="12 GB Ram",UnitPrice=15000,UnitsInStock=10},
                new Product{ProductId=3, CategoryId=1, ProductName="Lenovo Laptop",QuantityPerUnit="32 GB Ram",UnitPrice=8000,UnitsInStock=7},
                new Product{ProductId=4, CategoryId=2, ProductName="Samsung Telefon",QuantityPerUnit="6 GB Ram",UnitPrice=19000,UnitsInStock=16},
                new Product{ProductId=5, CategoryId=2, ProductName="Xiaomi Telefon",QuantityPerUnit="8 GB Ram",UnitPrice=12000,UnitsInStock=20},
            };

            //Oluşturulan yeni productların algoritmik bir şekilde listeleme
            
            Console.WriteLine("Algoritmik Yazma----------------------------"+"\n");

            foreach (var  product in products) //foreach ile products içerisinde gezilir
            {
                if (product.UnitPrice > 11000 && product.UnitsInStock>6) //if ile istenilen şartlar belirtilir.
                {
                    Console.WriteLine(product.ProductName); //içerisinde foreach ile gezilen products içerisinden, product ile productnameleri şartlara uyanlar çağrılır.
                }
            }


            //linq ile yukarıdaki algoritmil olarak yazılan listeleme işlemi yapılır.
            Console.WriteLine("\n"+"Linq ile Yazma-----------------"+"\n");

            //result değişkeni üzerinden where koşulu ile istenilen koşullar yazılır ve tolist ile listeleme formatı oluşturulur.
            var result = products.Where(product=>product.UnitPrice>11000 && product.UnitsInStock>6).ToList(); 
            //foreach ile result içerisindeki koşullar çağrılır.
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName); //productname çağrılır ve yukarıdaki koşullara uyanlar ekrana gelir.
            }

            GetProducts(products);
        }


        //GetProducts ile filtreleme yapma
        static List<Product> GetProducts(List<Product> products)
        {
            List<Product> filtreleProducts = new List<Product>();
            foreach (var product in products)
            {
                if (product.UnitPrice > 11000 && product.UnitsInStock > 6)
                {
                    filtreleProducts.Add(product);
                }
            }
            return filtreleProducts;
        }

        //linq ile filtreleme yapma
        static List<Product> GetProductsLinq(List<Product> products)
        {
            return products.Where(product => product.UnitPrice > 11000 && product.UnitsInStock > 6).ToList();
        }

    }

    //Product sınıfı oluşturulur.
    class Product 
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public Decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

    }
     //Category Sınıfı
    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}