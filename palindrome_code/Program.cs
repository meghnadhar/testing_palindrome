using System;

namespace palindrome_code
{
    class Program 
    {
        static void Main()
        {
            Console.WriteLine("Enter a string");
            string x = Console.ReadLine();
            
            Palindrom P1= new Palindrom();
            P1.IsPalindrom(x);
           
            
        }
    }

   public class Palindrom
    {
        public bool IsPalindrom(string s)
        {
            string revs="";
           
             for (int i = s.Length-1; i >=0; i--) //String Reverse
            {
                revs += s[i].ToString();
            }
            if (revs == s) 
            {   
                Console.WriteLine("String entered is a palindrome");
                return true;
            }
            else
            {   
                Console.WriteLine("String entered is not a palindrome");
                return false;
            }
           
        }
    }
}
