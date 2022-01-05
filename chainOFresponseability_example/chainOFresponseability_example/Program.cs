using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chainOFresponseability_example
{
    class Program
    {
        static void Main(string[] args)
        {
            handler num1 = new Concretehanler_one();
            handler num2 = new Concretehanler_tow();
            handler num3 = new Concretehanler_three();
            num1.setsuccessor(num2);
            num2.setsuccessor(num3);
            int[] req = { 2, 5, 4, 15, 8, 12, 24, 25 };
            foreach (int rqs in req)
            {
                num1.handlerRequest(rqs);
            }
            Console.ReadKey();
        }
    }
}
