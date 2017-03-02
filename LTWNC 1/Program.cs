using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTWNC_1
{
    class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime PublishDate { get; set; }
        public double Price { get; set; }
    }
    class Product
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        private int _Stock;
        public int Stock
        {
            get
            {
                return _Stock;
            }
            set
            {
                if (value < 0)
                {
                    _Stock = 0;
                } else
                {
                    _Stock = value;
                }
            }
        }
        public DateTime Publishdate { get; set; }

        public bool CheckInStock()
        {
            bool exist = false;
            if (Stock>0)
            {
                exist = true;
            } return exist;

        }

        public void inStock()
        {
            if (CheckInStock())
            {
                Console.WriteLine ("we have this product in the stock");
            }else
            {
                Console.WriteLine("we dont have this product in the stock");
            }
        }
    }

    class Employee
    {
        public int Salary { get; set; }

        public Employee()
        {
            Salary = 1000;
        }

        public Employee(int salary)
        {
            Salary = salary;
        }

        public Employee(int salaryWeek, int totalWeek)
        {
            Salary = salaryWeek * totalWeek;
        }

        public void WriteSalary()
        {
            Console.WriteLine(Salary);
        }
    }

    class Manager : Employee
    {
        public string Department { get; set; }

        public Manager()
        {

        }

        public Manager(string department, int salary)
            : base(salary)
        {
            Console.WriteLine("Department: " + department + "Salary is " + salary);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //5 List<int> numbers = new List<int> {99,23,13,15,18,54,32,63,69,1,7,9,4,16 };
            //List<int> oddnumbers = numbers.Where(i => i % 2 == 1).ToList();
            //List<int> evennumbers = numbers.Where(i => i % 2 == 0).ToList();

            //Console.WriteLine("OddNumber: ");
            //foreach(int num in oddnumbers)
            //{
            //    Console.WriteLine(num); 
            //}
            //Console.WriteLine("EvenNumber: ");
            //foreach (int num in evennumbers)
            //{
            //    Console.WriteLine(num);
            //5 }

            //4 Book b1 = new Book();
            //b1.Title = "Toi thay hoa vang tren co xanh";
            //b1.Description = "Nguyen Nhat Anh";
            //b1.Price = 200;
            //b1.PublishDate = DateTime.Now;

            //Book b2 = new Book();
            //b2.Title = "Hitch";
            //b2.Description = "Dale";
            //b2.Price = 150;
            //b2.PublishDate = DateTime.Now;

            //Book b3 = new Book();
            //b3.Title = "Ragnarok";
            //b3.Description = "Michelle";
            //b3.Price = 270;
            //b3.PublishDate = DateTime.Now;

            //Book b4 = new Book();
            //b4.Title = "Far Cry";
            //b4.Description = "Ub";
            //b4.Price = 30;
            //b4.PublishDate = DateTime.Now;

            //Book b5 = new Book();
            //b5.Title = "Lightning";
            //b5.Description = "FFXIII";
            //b5.Price = 320;
            //b5.PublishDate = DateTime.Now;

            //List<Book> listofBook = new List<Book>();
            //listofBook.Add(b1);
            //listofBook.Add(b2);
            //listofBook.Add(b3);
            //listofBook.Add(b4);
            //listofBook.Add(b5);

            //4a listofBook.Remove(b1);
            //List<Book> results = listofBook.Where(i => i.Price > 100).ToList();

            //foreach (Book b in listofBook)
            //{
            //    Console.WriteLine(b.Title);
            //4a }

            //foreach (Book b in listofBook)
            //{
            //    if (b.Title.Contains("Hitch"))
            //    {
            //        Console.WriteLine(b.Title + " " + b.Price);
            //    }
            //    if (b.Price < 100)
            //    {
            //        Console.WriteLine(b.Title + " " + b.Price);
            //    }
            //4 }

            //2 Employee emp1 = new Employee();
            //emp1.WriteSalary();
            //Employee emp2 = new Employee(2000);
            //emp2.WriteSalary();
            //Employee emp3 = new Employee(500,8);
            //2 emp3.WriteSalary();

            //3 Manager mng1 = new Manager("SEO ",1000);
            //mng1.WriteSalary();
            //Manager mng2 = new Manager("IT ",2000);
            //mng2.WriteSalary();
            //Manager mng3 = new Manager("ECO ", 4000);
            //3 mng3.WriteSalary();

            //2 Product product1 = new Product();

            //product1.ProductName = "sp1";
            //product1.Description = "etc";
            //product1.Price = 10;
            //product1.Stock = 100;
            //product1.Publishdate = DateTime.Now;

            //product1.inStock();
            //2 Console.WriteLine(product1.Stock);

            //1     List<Product> listofProducts = new List<Product>;
            //     listofProducts.Add(product1);
            //1     listofProducts.Add(product1);

            //2 Product product2 = new Product();

            //product2.ProductName = "sp2";
            //product2.Description = "etc";
            //product2.Price = 9;
            //product2.Stock = 90;
            //2 product2.Publishdate = DateTime.Now;

            //1      List<Product> listofProducts = new List<Product>;
            //      listofProducts.Add(product2);
            //1     listofProducts.Add(product2);

            //2      product2.inStock();
            //      Console.WriteLine(product2.Stock);

            //      Product product3 = new Product();

            //      product3.ProductName = "sp3";
            //      product3.Description = "etc";
            //      product3.Price = 8;
            //      product3.Stock = 80;
            //2      product3.Publishdate = DateTime.Now;

            ////1      List<Product> listofProducts = new List<Product>;
            ////      listofProducts.Add(product3);
            //// 1     listofProducts.Add(product3);

            //2      product3.inStock();
            // 2     Console.WriteLine(product3.Stock);

            //1     foreach (var prd in listofProducts)
            //     {
            //         Console.WriteLine(prd.ProductName + " " + prd.Price);
            // 1    } 
            Console.Read();
        }
    }
}
