using Decorator.Component;
using Decorator.ConcreteComponent;
using Decorator.ConcreteDecorator;
using Decorator.Decorator;
using System;

namespace DesignPatterns {
    class Program {
        static void Main(string[] args) {

            ICar car = new Suzuki();

            CarDecorator decorator = new OfferPrice(car);

            Console.WriteLine(String.Format("Make: {0} Price: {1} DiscountPrice: {2}", 
                decorator.Make, decorator.GetPrice(), decorator.GetDiscountedPrice()));

            Console.ReadLine();
        }
    }
}
