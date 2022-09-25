using Decorator.Component;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Decorator {
    public abstract class CarDecorator : ICar { //Make decorator abstract so we can add new functionality without implementation

        private ICar _car;
        public CarDecorator(ICar car) {
            _car = car;
        }

        public string Make => _car.Make;

        public double GetPrice() {
            return _car.GetPrice();
        }

        public abstract double GetDiscountedPrice();  //Added functionality dynamically, mark as abstract so implementing classes can
                                                      //override this and add functionality.
    }
}
