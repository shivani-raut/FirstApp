using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    public class TryCatch
    {
        public void tryCatch()
        {
            string s = "12.5";
            try
            {
                int a = int.Parse(s);
                Console.WriteLine(a);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                float f = float.Parse(s);
                Console.WriteLine(f);
                
            }
            int a1;
            bool b = int.TryParse(s,out a1);
            Console.WriteLine("{0}-{1}",b,a1);
        }
    }
}
