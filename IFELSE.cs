using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    public class IFELSE
    {
        public void checkEven()//access-sepicifier <return type><fn name>(<arguments>)
        {
            Console.WriteLine("Enter a number");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 != 0)
            {
                Console.WriteLine("It is odd");
            }
            else
            {
                Console.WriteLine("It is even");
            }
        }
        
    }
}
