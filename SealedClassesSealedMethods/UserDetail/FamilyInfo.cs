using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserDetail
{
    public class FamilyInfo : PersonalInfo
    {
        public string FatherName {get;set;}
        public string MotherName{get;set;}
        public int NoOfSiblings{get;set;}
        public string NativePlace{get;set;}
        public sealed override void Update( string nativePlace){
            
            NativePlace = nativePlace;
        }
        public void DisplayInfo(){
            Console.WriteLine($"Father name : {FatherName}\nMother Name : {MotherName}\nNo of siblings : {NoOfSiblings}\nNative place : {NativePlace}");
        }
    }
}