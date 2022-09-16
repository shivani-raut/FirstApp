using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    public delegate void Calculate(int x, int y);
    public class EventIntro
    {
        event Calculate calc;
        public void add(int x, int y)
        {
            Console.WriteLine("Addition done through delegate 10 + 20 =  " + (x + y));
        }
        public void subtract(int x, int y)
        {
            Console.WriteLine("Subtraction done through delegate 10 - 20 = " + (x - y));
        }
        public void multiply(int x, int y)
        {
            Console.WriteLine("Multiplye done through delegate 10 * 20 = " + (x * y));
        }
        public void divide(int x, int y)
        {
            Console.WriteLine("Division done through delegate 10 / 20 " + (x / y));
        }
        public void execute()
        {
            calc(10,20);

        }

        public EventIntro()
        {
            this.calc += new Calculate(this.add);
            this.calc += new Calculate(this.subtract);
            this.calc += new Calculate(this.multiply);
            this.calc += new Calculate(this.divide);
        }
    }
   
}
