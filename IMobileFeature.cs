using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_DotnetTraining
{
    public interface IMobileFeature
    {
        //public MobileFeature(int x, int y)
        //{
        //    x = 5;
        //    y = 5;
        //    Console.WriteLine($"{x} and {y} values");
        //}

        void Camera();

        string ModelNumber { get; set; }

         void Bluetooth(); /// declaration.
        void CallFunctions();
    }
}
