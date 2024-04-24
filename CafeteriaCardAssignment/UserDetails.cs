using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaCardAssignment;

/// <summary>
/// UserDetails class used to create and store values of user instance of <see cref="UserDetails"/> 
/// </summary>
public class UserDetails : PersonalInfo, IBalance
{
    //Field
    /// <summary>
    /// autoincrement userid
    /// </summary>
    private static int s_userID = 1000;
    /// <summary>
    /// holds balance value
    /// </summary>
    private double _balance;
    //properties
    /// <summary>
    /// This property used to store userID
    /// </summary>
    /// <value></value>
    public string UserID { get; }
    /// <summary>
    /// Workstation number used to store workstation number
    /// </summary>
    /// <value></value>
    public string WorkStationNumber { get; set; }
    /// <summary>
    /// Wallet balance returns the balance amount read only
    /// </summary>
    /// <value></value>
    public double WalletBalance { get{return _balance;} }
    //Paramterized constrcutor
    /// <summary>
    /// UserDetails used to create and store the values of the user of instance of <see cref="UserDetails"/> 
    /// </summary>
    /// <param name="userName">holds username</param>
    /// <param name="fatherName">holds fathername</param>
    /// <param name="mobileNumber">holds mobile number</param>
    /// <param name="mailID">holds mail id</param>
    /// <param name="gender">hols gender</param>
    /// <param name="workStationNumber">holds workstation number</param>
    /// <param name="balance">holds balance value</param>
    /// <returns>returns base class values</returns>
    public UserDetails(string userName, string fatherName, string mobileNumber, string mailID, Gender gender, string workStationNumber, double balance) : base(userName, fatherName, mobileNumber, mailID, gender)
    {
        UserID = "SF" + ++s_userID;
        WorkStationNumber = workStationNumber;
        _balance = balance;
    }
    //Methods
    /// <summary>
    /// This method used to recharge amount in wallet
    /// </summary>
    /// <param name="amount"></param>
    public void WalletRecharge(double amount)
    {
        _balance += amount;
    }
    /// <summary>
    /// this method used to deduct amount from wallet
    /// </summary>
    /// <param name="amount"></param> 
    public void DeductAmount(double amount)
    {
        _balance -= amount;
    }
    /// <summary>
    /// Binery search method used to do binary serach
    /// </summary>
    /// <param name="userID">search the userid</param>
    /// <param name="users">list is userdetails</param>
    /// <returns>returns the user object</returns>
    public static UserDetails BinarySearch(string userID, CustomList<UserDetails> users){
        int left = 0, right  = users.Count-1;
        while (left <= right)
        {
            
            int mid = (left +right) / 2;
            if (users[mid].UserID == userID)
            {
                return users[mid];
            }
            if (users[mid].UserID.CompareTo(userID)<0)
            {
                left = mid + 1;
            }

            else
            {
                right = mid - 1;
            }
        }
        return null;
        
    }
}
