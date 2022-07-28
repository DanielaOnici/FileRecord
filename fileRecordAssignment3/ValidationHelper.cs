    /*  fileRecordAssignment3.sln
    * 
    *  The program manages records of a member
    * 
    *  Daniela Onici
    *  Student ID# 8754297
    *  
    *  2022/07/25: created
    *  2022/07/28: finished
    * 
    */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace fileRecordAssignment3
{
    public class ValidationHelper
    {
        //Method to validate the memberId
        public static Boolean ValidateMember(string memberId)
        {
            Regex validMember = new Regex(@"^[A-Z]{2}[0-9]{4}[A-Z]{2}$");

            if(validMember.IsMatch(memberId))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //Method to validate the initials of the member ID
        public static Boolean ValidateInitials(string memberId, string firstName, string lastName)
        {
            char[] firstNameChars = firstName.ToCharArray();
            char[] lastNameChars = lastName.ToCharArray();
            char[] memberIdChars = memberId.ToCharArray();

            if (lastNameChars[0] == memberIdChars[memberIdChars.Length - 1] && firstNameChars[0] == memberIdChars[memberIdChars.Length - 2])
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Method to capitalize the first letter of a string and recognize a null/empty string
        public static string Capitalize(string word)
        {
            if(word == null || word == "")
            {
                return word;
            }
            else
            {
                char[] charArray = word.Trim().ToCharArray();
                charArray[0] = char.ToUpper(charArray[0]);

                return new string(charArray);
            }
        }

        //Method to validate the name with minimum 2 characters, maximum 12 without numbers or special characters
        public static Boolean ValidateName (string name)
        {
            Regex validName = new Regex(@"^[a-zA-Z]{2,12}$");

            if(validName.IsMatch(name))
            {
                return true;    
            }
            else
            {
                return false;
            }

        }

        //Method to validate the number. Must be equal or greater than 1
        public static Boolean ValidateNumber (int input)
        {
            if(input >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
