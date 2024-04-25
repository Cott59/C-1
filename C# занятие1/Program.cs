using System;

namespace C__занятие1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a;
            //a = Convert.ToInt32(Console.ReadLine());

            //if (a % 3 == 0)
            //{
            //    Console.WriteLine("Fizz ");
            //}
            //if (a % 5 == 0)
            //{
            //    Console.WriteLine("Buzz ");
            //}
            //else
            //{
            //    Console.WriteLine(a);
            //}

            //double b;
            //double proc;
            //b = Convert.ToInt32(Console.ReadLine());
            //proc = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(b/100*proc);

            int num1, num2;
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            int start = Math.Min(num1, num2);//тернарный оператор внутри
            (num1,num2)=(num2,num1);//свап 

            if(num1 > num2) {
                int tmp1 = num1; 
               int tmp2= num2;
                num2= tmp1;
                num1 = tmp2;
                
            }
            for(int i=num1; i<=num2; i++) {
                if(i%2 == 0)
                {
                    Console.WriteLine(i);
                }
            }




        }
    }
}
