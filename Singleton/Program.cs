using Singleton.Estudiante;
using System;

namespace Singleton {
    class Program {
        static void Main(string[] args) {
            SingletonClass fromEstud = SingletonClass.getInstance;
            fromEstud.PrintDetails("From student");

            SingletonClass fromEmployee = SingletonClass.getInstance;
            fromEmployee.PrintDetails("From employee");


            double result = Conversion.ToFarenheit(7);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
