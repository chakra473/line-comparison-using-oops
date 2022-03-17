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
            compare(a1 , b1 , a2, b2);
            
        }
       
        public static void compare(int a1,int b1,int a2,int b2)
        {
           
            int len3 = b1 - a1;
            int len4 = b2 - a2;
            if(Math.Abs(len3) == Math.Abs(len4))
            {
                Console.WriteLine("line 1 and line 2 are equal");
            }
            else if(Math.Abs(len3)>Math.Abs(len4) )
            {
                Console.WriteLine("line 1 is greater than line 2");
            }
            else
            {
                Console.WriteLine("line 2 is greater than line 1");
            }
        }
        
       
    }
}
