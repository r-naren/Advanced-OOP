using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibrary
{
    public class BookInfo : RackInfo
    {
        private static int s_bookID = 1000;
        public string  BookID {get;}
        public string BookName {get;set;}
        public string AuthorName {get;set;}
        public double Price {get;set;}
        public BookInfo(string departmentName, string degree,int rackNumber, int columnNumber, string bookName, string authorName, double price) : base(departmentName,  degree,rackNumber, columnNumber){
            BookID = "BID" + ++s_bookID;
            BookName = bookName;
            AuthorName = authorName;
            Price = price;
        }
        public void DisplayInfo(){
            Console.WriteLine($"Department Name : {DepartmentName}\nDegree: {Degree}\nRack number : {RackNumber}\nColumn Number : {ColumnNumber}\nBook ID : {BookID}\nBook Name : {BookName}\nAuthor Name : {AuthorName}\nPrice : {Price}");            
        }
    }
}