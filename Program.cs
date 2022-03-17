using System;
using System.Diagnostics;

namespace linecomparison
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("enter two points a1 and b1:");
            int a1=Convert.ToInt32(Console.ReadLine());
            int b1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter two points a2 and b2:");
            int a2=Convert.ToInt32(Console.ReadLine());
            int b2=Convert.ToInt32(Console.ReadLine());
           bool res= equal(a1, b1, a2, b2);
            Console.WriteLine("if both the lines are equal then it will return true else false");
            Console.WriteLine(res);
            
        }
       
        
        public static bool equal(int a1,int b1,int a2,int b2 )
        {
            int len1 = a1 - a2;
            int len2 = b1-b2;
            if(a1==a2)
            {
               return b1 == b2;
               
            }
            else if(len1==len2)
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
