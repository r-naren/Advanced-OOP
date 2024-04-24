using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegisterPerson
{
    public interface IFamilyInfo : IShowData
    {
        string FatherName{get;set;}
        string MotherName{get;set;}
        string HouseAddress{get;set;}
        int NoOfSiblings{get;set;}
        new void ShowInfo();
    }
    
}