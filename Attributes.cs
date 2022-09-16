using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace FirstApp
{
    public class Attributes
    {

        public void execute()
        {
            Rectangle r = new Rectangle(4.5, 7.5);
            r.Display();
            Type t = r.GetType();
            MethodInfo[] k = t.GetMethods(BindingFlags.Public |
                                                            BindingFlags.NonPublic |
                                                            BindingFlags.Instance |
                                                            BindingFlags.Static);
            MethodInfo[] k1 = new MethodInfo[k.Length];
            int c = 0;
            foreach (MethodInfo methodInfo in k)
            {
                String name = methodInfo.DeclaringType.ToString();
                if (name == "FirstApp.Attributes+Rectangle")
                {
                    k1[c] = methodInfo;
                    c++;
                }
                      
            }
            Attribute[] attrs = Attribute.GetCustomAttributes(t);
            
                //Console.WriteLine("Attributes Length - " + attrs.Length);
                foreach (Attribute attr in attrs)
                {
                    DeBugInfo dbi = (DeBugInfo)attr;
                    var assembly = Assembly.GetExecutingAssembly();
                    var types = assembly.GetTypes().Where(t => t.GetCustomAttributes<DeBugInfo>().Count() > 0);

                    foreach (var type in types)
                    {

                        //Console.WriteLine(type.Name);
                        Console.WriteLine("This class - {0}  is reviewd by {1} on {2}", type.Name, dbi.Developer, dbi.LastReview);
                        


                    }
                }
            for (int i = 0; i < c; i++)
            {
                Attribute[] attrs1 = Attribute.GetCustomAttributes(k1[i]);
                //Console.WriteLine("Attribute1 length" + attrs1.Length);
                if (attrs1.Length > 0)
                {
                    foreach (Attribute attr in attrs1)
                    {
                        try
                        {
                            DeBugInfo dbi = (DeBugInfo)attr;
                            //Console.WriteLine(dbi.Developer);
                            // Console.WriteLine("dbi generated");
                            Console.WriteLine("This Method - {0} is reviewd by {1} on {2}", k1[i].Name, dbi.Developer, dbi.LastReview);

                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }

                    }
                }
            }

        }

        [AttributeUsage(
      AttributeTargets.Class |
      AttributeTargets.Constructor |
      AttributeTargets.Field |
      AttributeTargets.Method |
      AttributeTargets.Property,
      AllowMultiple = true)]
        public class DeBugInfo : System.Attribute
        {
            private int bugNo;
            private string developer;
            private string lastReview;
            public string message;

            public DeBugInfo()
            {

            }
            public DeBugInfo(int bg, string dev, string d)
            {
                this.bugNo = bg;
                this.developer = dev;
                this.lastReview = d;
            }
            public int BugNo { get;set;}
            public string Developer
            {
                get
                {
                    return developer;
                }
            }
            public string LastReview
            {
                get
                {
                    return lastReview;
                }
            }
            public string Message
            {
                get
                {
                    return message;
                }
                set
                {
                    message = value;
                }
            }
        }
        [DeBugInfo(45, "Zara Ali", "12/8/2012", Message = "Return type mismatch")]
        [DeBugInfo(49, "Nuha Ali", "10/10/2012", Message = "Unused variable")]
        class Rectangle
        {
            //member variables
            protected double length;
            protected double width;

            public Rectangle(double l, double w)
            {
                length = l;
                width = w;
            }
            [DeBugInfo(55, "Zara Ali", "19/10/2012", Message = "Return type mismatch")]
            public double GetArea()
            {
                return length * width;
            }
            [DeBugInfo(56, "Zara Ali", "19/10/2012")]
            public void Display()
            {
                Console.WriteLine("Length: {0}", length);
                Console.WriteLine("Width: {0}", width);
                Console.WriteLine("Area: {0}", GetArea());
            }
        }//end class Rectangle

        
    }
}
