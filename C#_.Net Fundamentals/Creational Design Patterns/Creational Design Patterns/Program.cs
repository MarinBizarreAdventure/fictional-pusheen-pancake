using Creational_Design_Patterns.Abstract_Products;
using Creational_Design_Patterns.AbstractFactories;
using Creational_Design_Patterns.Concrete_Products;
using Creational_Design_Patterns.ConcreteFactories;
using Creational_Design_Patterns.Decorators;

class Program
{
    static void Main(string[] args)
    {
        IMilkFactory RegularMilkFactory = new RegularMilkFactory();
        IMilkFactory oatMilkFactory = new OatMilkFactory();
        IMilkFactory soyMilkFactory = new SoyMilkFactory();

        IMilk regular = RegularMilkFactory.CreateMilk();

        ICoffeeFactory espressoFactory = new EspressoFactory();
        ICoffee espresso= espressoFactory.CreateCoffee();
        espresso.Display();
        Console.WriteLine();


        ICoffeeFactory cappuccinoFactory = new CappuccinoFactory(oatMilkFactory.CreateMilk());
        ICoffee cappuccino = cappuccinoFactory.CreateCoffee();
        cappuccino.Display();
        Console.WriteLine();


        ICoffeeFactory flatWhiteFactory = new FlatWhiteFactory(oatMilkFactory.CreateMilk());
        ICoffee flatWhite = flatWhiteFactory.CreateCoffee();
        flatWhite.Display();
        Console.WriteLine();

        ICoffee flatWhiteWithMilkAndSugar = new SugarDecorator(new MilkDecorator(flatWhite, oatMilkFactory.CreateMilk()), 2);
        flatWhiteWithMilkAndSugar.Display();
        Console.WriteLine();


        ICoffee cappuccinoWithMilkAndSugar = new SugarDecorator(new MilkDecorator(cappuccino, soyMilkFactory.CreateMilk()), 5);
        cappuccinoWithMilkAndSugar.Display();
        Console.WriteLine();

    }

}