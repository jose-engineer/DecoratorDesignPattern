using Decorator.Component;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Decorator {
    public abstract class CarDecorator : ICar { //Make decaorator abstract so we can add new functionality without implementation

        private ICar _car;
        public CarDecorator(ICar car) {
            _car = car;
        }

        public string Make => _car.Make;

        public double GetPrice() {
            return _car.GetPrice();
        }

        public abstract double GetDiscountedPrice();  //Added functionality dynamically
    }
}
