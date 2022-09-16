using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    public class DelegatesIntro
    {
        public delegate void Calculate(int x, int y);
        public void add(int x,int y)
        {
            Console.WriteLine("Addition done through delegate 10 + 20 =  " + ( x + y));
        }
        public void subtract(int x,int y)
        {
            Console.WriteLine("Subtraction done through delegate 10 - 20 = " + (x - y)); 
        }
        public void multiply(int x,int y)
        {
            Console.WriteLine("Multiplye done through delegate 10 * 20 = " + (x * y)); 
        }
        public void divide(int x,int y)
        {
            Console.WriteLine("Division done through delegate 10 / 20 " + (x / y)); 
        }
        public void execute()
        {
            Calculate add_delegate = new Calculate(add);
            add_delegate(10, 20);
            Calculate sub_delegate = new Calculate(subtract);
            sub_delegate(10, 20);
            Calculate multiply_delegate = new Calculate(multiply);
            multiply_delegate(10, 20);
            Calculate divide_delegate = new Calculate(divide);
            divide_delegate(10, 20);
            //MultiCast Delegate
            Console.WriteLine("-----------MultiCast Delegate-----------------");
            Calculate multi_delegate = new Calculate(add);
            multi_delegate += subtract ;
            multi_delegate += multiply ;
            multi_delegate += divide ;
            multi_delegate.Invoke(10,20);

            
        }
    }
}
