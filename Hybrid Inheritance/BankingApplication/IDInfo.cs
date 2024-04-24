using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingApplication
{
    public class IDInfo : PersonalInfo
    {
        public string VoterID{get;set;}
        public string AadharID{get;set;}
        public string PANNumber{get;set;}
        public IDInfo(string name,  string phone,  DateTime dob, Gender gender, string voterID, string aadharID, string panNumber): base(name, phone, dob, gender){
            VoterID = voterID;
            AadharID = aadharID;
            PANNumber = panNumber;
        }
    }
}