using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_DotnetTraining
{
    enum days //Enum name
    {
        monday,
        tuesday,
        wednesday,
        thursday,
        friday,
        saturday,
        sunday
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Classes And Objects");
            //var x = 4; //Implicit casting
            //var res = Convert.ToString(x); //--> Boxing
            //var res1 = Convert.ToInt32(res); //Unboxing
            //2.Another approach of casting...
            MidBudgetMobile midBudgetMobile = new MidBudgetMobile();
           // var val2 = default(string);
           ////var resultString = val2.ToString();--> It will not support runtime exceptions and it block overall exec of applic
           // //Console.WriteLine($"{resultString}");
           // var resultString2 = Convert.ToString(val2);
           // Console.WriteLine($"{resultString2}");

            ///Console.WriteLine($"value of x:{Convert.ToString(x)}");
            //Student p = new Student();
            //p.StudentId = 5;
            //p.StudentName = "ASg";
            //Employee emp = default;
            //Console.WriteLine($"\nEmployee-Id:{emp.EmployeeId}\t");
            //Console.WriteLine($"\nEmployee-Name:{emp.EmployeeName}");
            //Employee employee = new Employee(55, "SHIV");
            //Console.WriteLine($"\nEmployee-Id:\t{employee.EmployeeId}\t");
            //Console.WriteLine($"\nEmployee-Name:\t{employee.EmployeeName}");
            //different logic.
            //Reads file from excel and do some calculations

            //Console.WriteLine("Value of Monday is " +
            //                            (decimal) days.monday);
            //Console.WriteLine("Value of Tuesday is " +
            //                            Convert.ToString(days.tuesday));
            //Console.WriteLine("Value of Wednesday is " +
            //                            (int) days.wednesday);
            //Console.WriteLine("Value of Thursday is " +
            //                            (int) days.thursday);
            //Console.WriteLine("Value of Friday is " +
            //                            (int) days.friday);
            //Console.WriteLine("Value of Saturday is " +
            //                            (int) days.saturday);
            //Console.WriteLine("Value of Sunday is " +
            //                            (int) days.sunday);
            //int a = 10;
            //int b = 0;
            //string name = null;
            //try
            //{
            //    ///int result = a%b;
            //    int lengthResult = name.Length;
            //   // Console.WriteLine($"Result: {result}");
            //    Console.WriteLine($"Result: {lengthResult}");
            //}
            //catch (NullReferenceException ex)
            //{
            //    Console.WriteLine($"Error:{ex.Message}");
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine($"Error:{ex.Message}");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Error:{ex.Message}");
            //}
            //Console.WriteLine("Try-catch block Ended1");
            //Console.WriteLine("Try-catch block Ended2");

            //var x = 55; //compileTimeType
            //object d = 55; //DynamicType 
            //if (a < b) // == equal to,!= Not equal to,<,>
            //{
            //    Console.WriteLine("b is Bigger");
            //}

            //else
            //{
            //    Console.WriteLine("a is Bigger");
            //}

            //2.Another approach
            //syntax
            //conditionCheck ? "string value" : "To print failure scenario";
            // var result = (a<b) ? "b is Bigger" : "a is Bigger"; //Null coaelescing check
            //Console.WriteLine(result);

            //for (; ; )
            //{
            //    Console.WriteLine("Hey! I am Trapped");
            //}
            //1.initialization
            //2.Condition
            // Do whatever inside in the loop.
            //3.Incremental phase
            //1. for(int i=0; i<=10000; i++)
            //{
            //    //$"string a<b int= o{i}"
            //    Console.WriteLine($"loop starts executing....{i}");////string interpolation.
            //}
            // //while loop

            // ///i=rr
            // ///
            // int i1 = 0;
            ////2. while(i1<=5)-- entry controlled loop.
            // {
            //     Console.WriteLine($"loop starts executing....{i1}");////string interpolation.
            //     i1++;
            // }
            ///3. do-while loop
            //    do //exist controlled loop
            //    {
            //        Console.WriteLine("loop started");
            //    }
            //    while (i1 <= 5);



            Console.ReadKey();
            }
        }
}
