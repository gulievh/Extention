using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethods1
{
    internal static class ExtentionMethods
    {
        public static bool IsOdd(this int number)
        {
            if (number % 2 == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        } 
        public static bool IsEven(this int number)
        {
            if (number % 2 == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool IsContainsDigit(this string str)
        {
            bool checkDigit=false;
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i])) { checkDigit = true; }
            }
            return checkDigit;
            {
                
            }
        }
       // public static string IsCapitalized(this string str)???
         // public static string GetValueIndexes(this string str)??
        
            
        
    }
}
