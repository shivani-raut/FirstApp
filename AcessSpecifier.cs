using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    public class AcessSpecifier
    {
        //Public - The code is accessible for all classes
        //Private - The code is only accessible within the same class
        //Protected - The code is accessible within the same class, or in a class that is inherited from that class. 
        //Internal - The code is only accessible within its own assembly, but not from another assembly.
        //Protected Internal - A protected internal member is accessible from the current assembly or from types that are derived from the containing class. 
        public string Name1 { get; set; }
        
        private string Name2 { get; set; }
        
        protected string Name3 { get; set; }
        
        internal string Name4 { get; set; }
        
        protected internal string Name5 { get; set; }
    }

    class Class1
    {
        public void checkvisibility()
        {
            AcessSpecifier acessSpecifier = new AcessSpecifier();
                Console.WriteLine(acessSpecifier.Name1);
                //Console.WriteLine(acessSpecifier.Name2); private variable error
                //Console.WriteLine(acessSpecifier.Name3); protected variable error
                Console.WriteLine(acessSpecifier.Name4);
                Console.WriteLine(acessSpecifier.Name5);
            
        }
    }
    class Class2 : AcessSpecifier
    {
        public void checkvisibility()
        {
            AcessSpecifier acessSpecifier = new AcessSpecifier();
            Class2 obj = new Class2();
           
                Console.WriteLine(acessSpecifier.Name1);
                //Console.WriteLine(acessSpecifier.Name2); private variable error
                //Console.WriteLine(acessSpecifier.Name3); error cannot called with parent class
                Console.WriteLine(obj.Name3); //called by child class
                Console.WriteLine(acessSpecifier.Name4);
                Console.WriteLine(acessSpecifier.Name5);
            
        }
    }
}
