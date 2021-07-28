using System;
using System.Threading.Tasks;
using System.Net.Http;
namespace ConsoleApp1
{
    class Program
    {       
        static async Task Main(string[] args)
        {
            await Method1();
            await Method2();
            await calladdition();
            Console.ReadKey();
        } 
        public static async Task Method1()
        {
             await Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Method 1 :" +i);
                    Task.Delay(100).Wait();
                }
            });
            
        }
        public static async Task Method2()
        {
            await Task.Run(() =>
            {
                for (int i = 10; i < 20; i++)
                {
                    Console.WriteLine("Method 2 : " +i);
                    Task.Delay(100).Wait();
                }
            });

        }
        public static async Task<int> addition()
        {
            int sum=0,a=5,b=6;
            await Task.Run(() =>
            {
                sum = a + b;
            });
            return sum;
        }
        public static async Task calladdition()
        {
            int sum = await addition();
            Method3(sum);
        }
        public static void Method3(int sum)
        {
            Console.WriteLine("Addition is : " + sum);
        }

    }
}
