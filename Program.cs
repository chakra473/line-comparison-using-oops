using System;
using System.Diagnostics;

namespace linecomparison
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter x1 and y1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());   
            Console.WriteLine("enter x2 and y2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());   
            line(x1, x2,y1,y2);
            Console.WriteLine("enter two points a1 and b1:");
            int a1=Convert.ToInt32(Console.ReadLine());
            int b1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter two points a2 and b2:");
            int a2=Convert.ToInt32(Console.ReadLine());
            int b2=Convert.ToInt32(Console.ReadLine());
           bool res= equal(a1, b1, a2, b2);
            Console.WriteLine("if both the lines are equal then it will return true else false");
            Console.WriteLine(res);
            compare(a1 , b1 , a2, b2);
            
        }
        public static void line(int x1 ,int x2 ,int y1, int y2)
        {
           
            int lenght;
            lenght=(x2-x1)*(x2-x1)+(y2-y1)*(y2-y1);
            double lenght1=Math.Sqrt(lenght);
            Console.WriteLine("lenght of the coordinates x1,y1 and x2,y2 is "+lenght1);
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
