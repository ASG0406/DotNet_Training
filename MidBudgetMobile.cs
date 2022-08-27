using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_DotnetTraining
{
    public class MidBudgetMobile : MobileFeature
    {
        public override void Camera()
        {
            Console.WriteLine("8MP camera");
        }

        public string ModelNumberWithYear { get; set; }
        public MidBudgetMobile() //Default constructor
        {
            this.Camera();
            this.Bluetooth();
            if (this.ModelNumber == "Poco F1")
            {
                ModelNumberWithYear = this.ModelNumber + "2021";
            }
            Console.WriteLine(ModelNumberWithYear);
            this.CallFunctions();
        }
        public override void Bluetooth()
        {
            Console.WriteLine("V2.1 F/bluetooth");
        }
        public override string ModelNumber {
            get { return ModelNumberWithYear; }
            set => this.ModelNumberWithYear = value; 
        }

    }
}
