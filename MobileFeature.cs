using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_DotnetTraining
{
    public abstract class MobileFeature
    {
        public MobileFeature()
        {
            this.ModelNumber = "Poco F1";
        }
        //public MobileFeature(int x, int y)
        //{
        //    x = 5;
        //    y = 5;
        //    Console.WriteLine($"{x} and {y} values");
        //}

        public abstract void Camera();
        
        public abstract string ModelNumber { get; set; }

        public abstract void Bluetooth(); /// declaration.
        public  void CallFunctions()
        {
            Console.WriteLine("Incoming and Outgoing calls");
        }
    }
}
