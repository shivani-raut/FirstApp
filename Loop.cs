using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    public class Loop
    {
        public void loop()
        {
            //For loop
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            //While
            int a=0;
            while(a<10)
            {
                Console.WriteLine(a);
                a++;
            }
            //Do while
            do
            {
                Console.WriteLine(a);
                a++;
            }
            while (a < 20);
            //for each 
            int[] a1 = new int[5];
            for(int i = 0; i < a1.Length; i++)
                a1[i] = i;
            foreach(int i in a1)//foreach(datatype var-name in array-name)
                Console.WriteLine(i);
        }
    }
}
