using Decorator.Component;
using Decorator.Decorator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.ConcreteDecorator {
    public class OfferPrice : CarDecorator {

        public OfferPrice(ICar car) : base(car){ // pass car object to base

        }

        public override double GetDiscountedPrice() {
            return 0.8 * base.GetPrice(); // use the car object
        }
    }
}
