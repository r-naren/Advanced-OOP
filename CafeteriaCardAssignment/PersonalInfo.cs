using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaCardAssignment
{
    /// <summary>
    /// Gender enum is used to store the gender (Male-0, Female-2, Trangender-2)
    /// </summary>
    public enum Gender { Male, Female, Transgender }
    /// <summary>
    /// PersonalInfo class used to create and store the details of persona of instance of <see cref="PersonalInfo"/> 
    /// </summary>
    public class PersonalInfo
    {
        //Properties
        /// <summary>
        /// this property used to store username of instance of <see cref="PersonalInfo"/> 
        /// </summary>
        /// <value></value>
        public string UserName { get; set; }
        /// <summary>
        /// this property used to store fathername of instance of <see cref="PersonalInfo"/> 
        /// </summary>
        /// <value></value>
        public string FatherName { get; set; }
        /// <summary>
        /// this property is used to store mobilenumber of instance of <see cref="PersonalInfo"/> 
        /// </summary>
        /// <value>Ex : 9876543210</value>
        public string MobileNumber { get; set; }
        /// <summary>
        /// this property is used to store mail id of instance of <see cref="PersonalInfo"/> 
        /// </summary>
        /// <value></value>
        public string MailID { get; set; }
        /// <summary>
        /// this property used to store the gender value of instance of <see cref="PersonalInfo"/> 
        /// </summary>
        /// <value></value>
        public Gender Gender { get; set; }
        //Paramterized constrcutor
        /// <summary>
        /// PersonalInfo constructor used to create and assign values to instance of <see cref="PersonalInfo"/> 
        /// </summary>
        /// <param name="userName">holds username</param>
        /// <param name="fatherName">holds fathername</param>
        /// <param name="mobileNumber">holds mobilenumber</param>
        /// <param name="mailID">holds mailid</param>
        /// <param name="gender">holds gender</param> 
        public PersonalInfo(string userName, string fatherName, string mobileNumber, string mailID, Gender gender)
        {
            UserName = userName;
            FatherName = fatherName;
            MobileNumber = mobileNumber;
            MailID = mailID;
            Gender = gender;
        }
        /// <summary>
        /// ShowMyProfile method used to show the profile of the user
        /// </summary>
        public void ShowMyProfile()
        {
            Console.WriteLine($"User name : {UserName}\nFather name : {FatherName}\nMobile number : {MobileNumber}\nMail ID : {MailID}\nGender : {Gender}");

        }
        
    }
}