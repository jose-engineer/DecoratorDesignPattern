using Decorator.Component;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.ConcreteComponent {
    public sealed class Hyundai : ICar { //This class couold be a sealed class and even then you can wrap it
        public string Make { get => "HatchBack"; }

        public double GetPrice() {
            return 200000;
        }
    }
}
