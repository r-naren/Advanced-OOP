using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace onlineMedicalStore
{
    /// <summary>
    /// MedicineDetails class is used to create and store the details of the medicine details <see cref="MedicineDetails"/> 
    /// </summary>
    public class MedicineDetails
    {
        /// <summary>
        /// this field used for autoincrementation of medicine id
        /// </summary>
        private static int s_medicineID = 100;
        /// <summary>
        /// this property used to store the medicine id of instance of <see cref="MedicineDetails"/> 
        /// </summary>
        /// <value></value>
        public string MedicineID {get;}
        /// <summary>
        /// this property used to store medicine name of instance of <see cref="MedicineDetails"/> 
        /// </summary>
        /// <value></value>
        public string MedicineName {get;set;}
        /// <summary>
        /// this property used to store available count of instance of <see cref="MedicineDetails"/> 
        /// </summary>
        /// <value>Range (0-200000000)</value>
        public int AvailableCount {get;set;}
        /// <summary>
        /// this property used to store the price of the medicine of instance of <see cref="MedicineDetails"/> 
        /// </summary>
        /// <value>Range(0-2000000000)</value>
        public int Price {get;set;}
        /// <summary>
        /// this property used to store the expiry date of the medicine of instance of <see cref="MedicineDetails"/> 
        /// </summary>
        /// <value></value>
        public DateTime DateOfExpiry {get;set;}
        /// <summary>
        /// MedicineDetails constructor is used to create and assign to its instance of <see cref="MedicineDetails"/> 
        /// </summary>
        /// <param name="medicineName"></param>
        /// <param name="availableCount"></param>
        /// <param name="price"></param>
        /// <param name="dateOfExpiry"></param>
        public MedicineDetails(string medicineName, int availableCount, int price, DateTime dateOfExpiry){
            MedicineID = "MD"+ ++s_medicineID;
            MedicineName = medicineName;
            AvailableCount = availableCount;
            Price = price;
            DateOfExpiry = dateOfExpiry;
        }
        /// <summary>
        /// MedicineDetails constructor used to create and assign from csv to its instance of <see cref="MedicineDetails"/>  
        /// </summary>
        /// <param name="content"></param>
        public MedicineDetails(string content){
            string[] values = content.Split(",");
            MedicineID = values[0];
            s_medicineID = int.Parse(values[0].Remove(0,2));
            MedicineName = values[1];
            AvailableCount = int.Parse(values[2]);
            Price = int.Parse(values[3]);
            DateOfExpiry = DateTime.ParseExact(values[4],"dd/MM/yyyy",null);
        }
    }
}