using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyConstrucorinCSharp
{
    class Base { }
    class Derived : Base { }

    class Program
    {
        static void Main()
        {
            ShowType(new Derived());
        }

        static void ShowType(Base b)
        {
            Console.WriteLine(typeof(Base));
            Console.WriteLine(typeof(Derived));
            Console.WriteLine(b.GetType());
            
            int a = 1;
            Console.WriteLine(typeof(Int32));
            Console.WriteLine(typeof(int));
            Console.WriteLine(a.GetType());
            
            object x;
            x = 15;
            Console.WriteLine(typeof(object));
            Console.WriteLine(x.GetType());
            x = "fghrbntju";
            Console.WriteLine(typeof(object));
            Console.WriteLine(x.GetType());
            Console.Read();
        }
    }
    //class employee
    //{
    //    public string name;
    //    public int age;
    //    public employee(employee emp)   // declaring Copy constructor.
    //    {
    //        name = emp.name;
    //        age = emp.age;
    //    }
    //    public employee(string name, int age)  // Instance constructor.
    //    {
    //        this.name = name;
    //        this.age = age;
    //    }
    //    public string Details     // Get deatils of employee
    //    {
    //        get
    //        {
    //            return " The age of " + name + " is " + age.ToString();
    //        }
    //    }
    //}

    //class Program
    //{

    //    static void Main(string[] args)
    //    {
    //        employee emp1 = new employee("Vithal", 23);  // Create a new employee object.
    //        employee emp2 = new employee(emp1);          // here is emp1 details is copied to emp2.
    //        employee emp3 = emp1;
    //        Console.WriteLine(emp2.Details);
    //        emp1.age = 21;
    //        Console.WriteLine(emp1.Details);
    //        Console.WriteLine(emp2.Details);
    //        Console.WriteLine(emp3.Details);
    //        emp3.name = "changes";
    //        Console.WriteLine(emp1.Details);
    //        Console.WriteLine(emp2.Details);
    //        Console.WriteLine(emp3.Details);
    //        Console.ReadLine();
    //    }
    //}
}
