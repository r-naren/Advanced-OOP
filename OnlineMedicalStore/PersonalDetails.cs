using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace onlineMedicalStore
{
    /// <summary>
    /// PersonalDetails class is used to create and store the details of a person <see cref="PersonalDetails"/> 
    /// </summary>
    public class PersonalDetails
    {
        /// <summary>
        /// this property used to store name of instance of <see cref="PersonalDetails"/>
        /// </summary>
        /// <value>Ex : Ravi</value>
        public string Name {get;set;}
        /// <summary>
        /// this property used to store age of instance of <see cref="PersonalDetails"/>
        /// </summary>
        /// <value>Range (0-200000000)</value>
        public int Age {get;set;}
        /// <summary>
        /// this property used to store city name of instance of <see cref="PersonalDetails"/>
        /// </summary>
        /// <value>Ex : Chennai</value>
        public string City {get;set;}
        /// <summary>
        /// this property used to store the phone number of instance of <see cref="PersonalDetails"/>
        /// </summary>
        /// <value>Ex : 9876543210</value>
        public string PhoneNumber {get;set;}
        /// <summary>
        /// PersonalDetails constructor used to create and assign the values to its instance of <see cref="PersonalDetails"/>
        /// </summary>
        /// <param name="name">holds name</param>
        /// <param name="age">holds age</param>
        /// <param name="city">holds city name</param>
        /// <param name="phoneNumber">holds phone number</param>
        public PersonalDetails(string name, int age, string city, string phoneNumber){
            Name = name;
            Age = age;
            City = city;
            PhoneNumber = phoneNumber;
        }
        /// <summary>
        /// PersonalDetails empty constructore assign default values to its instance of <see cref="PersonalDetails"/>
        /// </summary>
        public PersonalDetails(){
            
        }
    }
}