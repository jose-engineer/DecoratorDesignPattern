using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Component {
    public interface ICar {
        public string Make { get; }
        public double GetPrice();
    }
}
