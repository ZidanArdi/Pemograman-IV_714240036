
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_714240036
{
    public class DVD_714240036 : Product_714240036
    {
        protected string duration;
        public DVD_714240036( string title, string duration)
        {
            MyType = "DVD";
            MyTitle = title;
            this.duration = duration;
            Console.WriteLine("ini dari class DVD");
        }
        public string Duration
        {
            get { return duration; }
            set { duration = value; }
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("Product is a {0} called \"{1}\" and has a duration of {2} minutes ", MyType, MyTitle, Duration);
        }
    }
}
