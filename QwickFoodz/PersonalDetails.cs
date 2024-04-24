using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QwickFoodz
{
    //class
    /// <summary>
    /// Gender enum is used for gender classification
    /// </summary> 
    public enum Gender { Select, Male, Female, Transgender }
    /// <summary>
    /// PersonalDetails class is used to store personal details of instance of <see cref="PersonalDetails"/>
    /// </summary>
    public class PersonalDetails
    {
        // properties
        /// <summary>
        /// Name Property is instance of <see cref="PersonalDetails"/>
        /// </summary> 
        /// <value>String value, Ex : Ravi</value>
        public string Name { get; set; }
        /// <summary>
        /// FatherName Property is instance of <see cref="PersonalDetails"/>
        /// </summary>
        /// <value>String value, Ex : Ettaparajan</value>
        public string FatherName { get; set; }
        /// <summary>
        /// Gender Property is instance of <see cref="PersonalDetails"/>
        /// </summary>
        /// <value>Gender enum value (Select-1,Male-1, Female-2, Transgender-3)</value>
        public Gender Gender { get; set; }
        /// <summary>
        /// Mobile Property is instance of <see cref="PersonalDetails"/>
        /// </summary>
        /// <value>Indian Mobile Number 10 digits, Ex : 9876543210</value>
        public string Mobile { get; set; }
        /// <summary>
        /// DOB Property is instance of <see cref="PersonalDetails"/>
        /// </summary>
        /// <value>In dd/MM/yyyy date format, Ex : 01/01/2001</value>
        public DateTime DOB { get; set; }
        /// <summary>
        /// MailID Property is instance of <see cref="PersonalDetails"/>
        /// </summary>
        /// <value>Ex : ravi@gmail.com</value>
        public string MailID { get; set; }
        /// <summary>
        /// Location Property is instance of <see cref="PersonalDetails"/>
        /// </summary>
        /// <value>City Name, Ex : Chennai</value>
        public string Location { get; set; }
        //parametrized constructor
        /// <summary>
        /// PersonalDetails constructor used for creatinga and assigning values to  instance of <see cref="PersonalDetails"/>
        /// </summary>
        /// <param name="name">name of person</param>
        /// <param name="fatherName">fathername of the person</param>
        /// <param name="gender">gender of the person</param>
        /// <param name="mobile">mobile number of the person</param>
        /// <param name="dob">dob of ther person</param>
        /// <param name="mailID">mail id of the person</param>
        /// <param name="location">location of the person</param> 
        public PersonalDetails(string name, string fatherName, Gender gender, string mobile, DateTime dob, string mailID, string location)
        {
            Name = name;
            FatherName = fatherName;
            Gender = gender;
            Mobile = mobile;
            DOB = dob;
            MailID = mailID;
            Location = location;
        }
        /// <summary>
        /// This is empty conturutor invoked when no paramters passed and assign default values to the properties.
        /// </summary>
        public PersonalDetails()
        {

        }

    }
}