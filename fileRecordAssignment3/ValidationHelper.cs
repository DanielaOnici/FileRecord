    /*  fileRecordAssignment3.sln
    * 
    *  The program manages records of a member
    * 
    *  Daniela Onici
    *  Student ID# 8754297
    *  
    *  2022/07/25: created
    *  2022/07/27: finished
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
    }
}
