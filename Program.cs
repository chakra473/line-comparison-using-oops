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
            
        }
        public static void line(int x1 ,int x2 ,int y1, int y2)
        {
           
            int lenght;
            lenght=(x2-x1)*(x2-x1)+(y2-y1)*(y2-y1);
            double lenght1=Math.Sqrt(lenght);
            Console.WriteLine("lenght of the coordinates x1,y1 and x2,y2 is "+lenght1);
        }
        
        
       
    }
}
