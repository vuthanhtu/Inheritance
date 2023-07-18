using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuThanhTu.Csharp.P1.P001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Starting Program
            Console.WriteLine("Csharp.P1.P001.Excercise1");
            //initial a Book object
            Book book = new Book("One Piece", "82521949191", "EchiroOda", "Tokyo");
            //get book infomation
            Console.WriteLine(book.GetBookInfomation());
            Console.WriteLine("Csharp.P1.P001.Excercise2");
            //initial a Employee object
            Employee employee = new Employee("Vu", "Thanh Tu",500000) ;
            //Employee employee2 = new Employee();
            //employee2.SalaryMonth = -2500;
            //Console.WriteLine(employee.GetInfomation());
        }
    }
    //Excercise-1
    public class Book
    {
        public string BookName { get; set; }
        public string ISBN { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }

        public Book()
        {

        }
        public Book(string bookName, string ISBN, string author, string publisher)
        {
            this.BookName = bookName;
            this.ISBN = ISBN;
            this.Author = author;
            this.Publisher = publisher;
        }

        public string GetBookInfomation()
        {
            return $"{this.BookName}-{this.ISBN}-{this.Author}-{this.Publisher}";
        }
    }

    //Excercise2
    public class Employee
    {
        private double salaryMonth;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double SalaryMonth
        {
            //get => salaryMonth;
            //set => salaryMonth = (salaryMonth > 0) ? value : 0.0;
            get;
            set;
        }
        public Employee()
        {

        }
        public Employee( string firstName, string lastName,double salaryMonth)
        {
            
            this.FirstName = firstName;
            this.LastName = lastName;
            this.SalaryMonth = (salaryMonth > 0) ? salaryMonth : 0.0;
        }
        public string GetInfomation()
        {
            return $"{this.FirstName}-{this.LastName}-{this.SalaryMonth}";
        }
    }
    //Excercise3

}
