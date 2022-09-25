using Decorator.Component;
using Decorator.ConcreteComponent;
using Decorator.ConcreteDecorator;
using Decorator.Decorator;
using System;

namespace DesignPatterns {
    class Program {
        static void Main(string[] args) {

            ICar car1 = new Suzuki();
            ICar car2 = new Hyundai();

            CarDecorator decorator1 = new OfferPrice(car1);
            CarDecorator decorator2 = new OfferPrice(car2);

            Console.WriteLine(String.Format("Make: {0} Price: {1} DiscountPrice: {2}", 
                decorator1.Make, decorator1.GetPrice(), decorator1.GetDiscountedPrice()));

            Console.WriteLine(String.Format("Make: {0} Price: {1} DiscountPrice: {2}",
                decorator2.Make, decorator2.GetPrice(), decorator2.GetDiscountedPrice()));

            Console.ReadLine();
        }
    }
}
