using SingletonDemo.Estudiante;
using System;

namespace SingletonDemo {
    class Program {
        static void Main(string[] args) {
            Singleton fromEstud = Singleton.getInstance;
            fromEstud.PrintDetails("From student");

            Singleton fromEmployee = Singleton.getInstance;
            fromEmployee.PrintDetails("From employee");


            double result = Conversion.ToFarenheit(7);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
