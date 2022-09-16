using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Primitive and non primitive
    Primitive (Predefined)
        byte,short,int,float,double,long,char,bool,datetime,string,object,etc 
    Non-Primitive (User Defined)
        class,struct,enum,interface,delegate,array
*/
namespace FirstApp
{
    public class DataType
    {
        public void dataType()
        {
            int a = 10;
            float f = 0.6f;// suffix f shows float
            double d = 0.7;// no suffix shows double
            decimal de = 0.98877675m;//suffix m shows decimal
            string name = "shivani";
            int index = name.IndexOf('v');//3
            char c = 'A';
            Console.WriteLine("Integer - {0},Float - {1},Decimal - {2}",a,f,d);
            int divide = (int)(a/f);//Explicit
            float divide1 = a/10;//Implicit

            string int1 = a.ToString();//type Conversion

            //Parsing
            string s = "12";
            int num = Int32.Parse(s);
            int num1 = Convert.ToInt32(s);
            Console.WriteLine(num);
        
        }
        /*value and refernce type
         * Value Type
                Value types are fixed in size.
                Value types are made in system stack.
                Ex - all primitive data types except string and object
         * Reference Type
                Reference types are not fixed in size.
                They are maintained in system managed heap but it also uses stack to store reference of heap.
                Ex - Primitive(string, object)
                     Non primitive(Class, interface, delegate, array)
         */

        /* Boxing and Unboxing
         * Boxing
            Boxing is a mechanism in which value type is converted into reference type.
            It is implicit conversion process in which object type (super type) is used.
            In this process type and value both are stored in object type
         * Unboxing
            Unboxing is a mechanism in which reference type is converted into value.
            It is explicit conversion process.
        */
        public void boxingUnboxing()
        {
            
            int i = 10;
            object o = i;             // boxing  
            int j = (int)o;          // unboxing  
            Console.WriteLine("value of o object : " + o);
            Console.WriteLine("Value of j : " + j);
        }
    }
}
