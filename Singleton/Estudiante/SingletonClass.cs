using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.Estudiante {
    public sealed class SingletonClass { //sealed restricts the inheritance,
                                         //if sealed not used you can create multiple instance if you use nested classes
        private static int counter = 0;
        private static SingletonClass instance = null;

        public static SingletonClass getInstance
        {
            get
            {
                if (instance == null)
                    instance = new SingletonClass();
                return instance;
            }
        } // property that creates instances, public is used to return only one instance of the class leveraging on the private property

        private SingletonClass() { //"private" restrict multiple intance creation
            counter++;
            Console.WriteLine("Contador: " + counter.ToString());
        } //"private" ensures that object is not instantiated other than with in the class itself

        public void PrintDetails(string msg) {
            Console.WriteLine(msg);
        }
    }

    public static class Conversion {
        public static double ToFarenheit(double celsius) {
            return (celsius * 9 / 5) + 32;
        }
    }

}
