using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceryShop
{
    /// <summary>
    /// gender enum holds gender value (Male-0, Female-1, Transgender-2)
    /// </summary>
    public enum Gender { Male, Female, Transgender }
    /// <summary>
    /// PersonalDetails used to create and store the details of person of instance of <see cref="PersonalDetails"/>
    /// </summary>
    public class PersonalDetails
    {
        /// <summary>
        /// Name used to store name of instance of <see cref="PersonalDetails"/>
        /// </summary>
        /// <value></value>
        public string Name { get; set; }
        /// <summary>
        /// this property holds the father name of instance of <see cref="PersonalDetails"/>
        /// </summary>
        /// <value></value>
        public string FatherName { get; set; }
        /// <summary>
        /// gender store the gender details of instance of <see cref="PersonalDetails"/>
        /// </summary>
        /// <value></value>
        public Gender Gender { get; set; }
        /// <summary>
        /// Mobile number property is instance of <see cref="PersonalDetails"/>
        /// </summary>
        /// <value></value>
        public string MobileNumber { get; set; }
        /// <summary>
        /// this property holds mail id of instance of <see cref="PersonalDetails"/>
        /// </summary>
        /// <value></value>
        public string MailID { get; set; }
        /// <summary>
        /// this property holds the dob of instance of <see cref="PersonalDetails"/> 
        /// </summary>
        /// <value></value>
        public DateTime DOB { get; set; }

        //Paramterized constrcutor
        /// <summary>
        /// Personaldetails constructore used to create and assign the pseronal values of instance of <see cref="PersonalDetails"/>
        /// </summary>
        /// <param name="name">holds name</param>
        /// <param name="fatherName">holds fathername</param>
        /// <param name="gender">holds gender</param>
        /// <param name="mobileNumber">holds mobile number</param>
        /// <param name="mailID">holds mail id</param>
        /// <param name="dob">holds dob</param>
        public PersonalDetails(string name, string fatherName, Gender gender, string mobileNumber, string mailID, DateTime dob)
        {
            Name = name;
            FatherName = fatherName;
            MobileNumber = mobileNumber;
            MailID = mailID;
            Gender = gender;
            DOB = dob;
        }
        /// <summary>
        /// PeronalDetails constructor used to create and assign values from csv of instance of <see cref="PersonalDetails"/>
        /// </summary>
        /// <param name="content"></param>
        public PersonalDetails(string  content)
        {
            string[] values = content.Split(",");
            Name = values[1];
            FatherName = values[2];
            Gender = Enum.Parse<Gender>(values[3],true);
            MobileNumber = values[4];
            MailID = values[5];
            
            DOB = DateTime.ParseExact(values[6],"dd/MM/yyyy",null);
        }
        /// <summary>
        /// This method shows the profile of the user
        /// </summary>
        public void ShowMyProfile()
        {
            Console.WriteLine($"Name : {Name}\nFather name : {FatherName}\nGender : {Gender}\nMobile number : {MobileNumber}\nMail ID : {MailID}\nDOB : {DOB.ToString("dd/MM/yyyy")}");

        }
    }
}