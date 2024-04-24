using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class EEEDepartment : Library
    {
        public override string AuthorName {get;set;}
        public override string BookName {get;set;}
        public override string PublisherName{get;set;}
        public override string Year {get;set;}
        
        public EEEDepartment() : base(){
            
        }
        public override void SetBookInfo(string authorName, string bookname, string publisherName, string year){
            AuthorName = authorName;
            BookName = bookname;
            PublisherName = publisherName;
            Year = year;
        }
        public override void DisplayInfo(){
            Console.WriteLine($"Serial Number: {SerialNumber} | Author Name : {AuthorName} | Book Name : {BookName} | Publisher Name : {PublisherName} | Year : {Year}");
            
        }
        
    }
}