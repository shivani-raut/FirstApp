using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    public class SyncAsync
    {
        public async Task Execute()
        {
            //Method1();
            //Method2();
            await callMethod();
        }
        

        public static async Task callMethod()
        {
            
            Task<int> result = Method1();
            Method2();
            Console.WriteLine("Method 2 Completed");
            var count = await result;
            Console.WriteLine("Method 1 Completed");
            Method3(count);
            Console.WriteLine("Method 3 Completed");
        }

        public static async Task<int> Method1()
        {
            int count = 0;
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    
                    count += 1;
                    Console.WriteLine(count);
                }
            });

            
            return count;
        }

        public async static void Method2()
        {

            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine(" Method 2");
            }
            //await Task.Delay(100);
            
        }

        public static void Method3(int count)
        {
            Console.WriteLine("Total count is " + count);
        }

        /*
        public void Method2()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(" Method 2");
                // Do something
                Task.Delay(1000).Wait();
            }
        }

        public async Task Method1()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine(" Method 1");
                    // Do something
                    Task.Delay(100).Wait();
                }
            });
        }
        */
    }
}
