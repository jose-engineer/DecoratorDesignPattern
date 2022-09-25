using Decorator.Component;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.ConcreteComponent {
    public sealed class Suzuki : ICar {
        public string Make => "SUV";

        public double GetPrice() {
            return 20000;
        }
    }
}
