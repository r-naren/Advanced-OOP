using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    // class
    /// <summary>
    /// This class is used to create instance for PersonalDetails class <see cref="PersonalDetails"/>
    /// </summary>
    public class PersonalDetails
    {
        // properties
        /// <summary>
        /// userName property is used to create instance of userName for PersonalDetails <see cref="PersonalDetails"/>
        /// </summary>
        /// <value>Enter you Name - Ex : Ravi</value>
        public string UserName { get; set; }
        /// <summary>
        /// PhoneNumber property is used to create instance of PhoneNumber for PersonalDetails <see cref="PersonalDetails"/>
        /// </summary>
        /// <value>Enter Indian Phone number - Ex : 9876543210 </value>
        public string PhoneNumber { get; set; }
        // parametrized constructor
        /// <summary>
        /// This parametrized contructor is used to assign values for userName and phoneNumber while creating object for class <see cref="PersonalDetails"/>
        /// </summary>
        /// <param name="userName">Containes userName of the user</param>
        /// <param name="phoneNumber">contains phoneNumber of the user</param> 
        /// <summary>
        public PersonalDetails(string userName, string phoneNumber)
        {
            UserName = userName;
            PhoneNumber = phoneNumber;
        }
        /// <summary>
        /// Empty constructor
        /// </summary>
        public PersonalDetails()
        {
        }
    }
}