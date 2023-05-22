using OOPS;
using System;

// Customer obj = new Customer();
//obj.displayData();
//fields calling
// Console.WriteLine("Customer=" + obj.CustID);
// Console.WriteLine("Name=" + obj.Name);
// Console.WriteLine("Address=" + obj.Address);

// FunOverLoad obj1 = new FunOverLoad();
// obj1.setName("Tom");
// Console.WriteLine("Name=" + obj1.name);
// obj1.setName("Tom", "Jerry");
// Console.WriteLine("Name=" + obj1.name);
// obj1.setName("Tom", "Jerry", "Spike");
// Console.WriteLine("Name=" + obj1.name);

// PartialPart obj1 = new PartialPart();
// obj1.displayData1();
// obj1.displayData2();

// Encapsulation objencaps = new Encapsulation(20);
// objencaps.MySquare();

// Father objfather = new Father();
// objfather.FatherMethod();
// //Here Child object can access both class methods
// Child objchild = new Child();
// objchild.FatherMethod();
// objchild.ChildMethod();

//Interface
// IShape[] shapes = new IShape[3];
// shapes[0] = new Circle(5);
// shapes[1] = new Square(4);
// shapes[2] = new Triangle(4, 5);
// foreach (IShape shape in shapes)
// {
//     shape.Display();
//     Console.WriteLine("Area: " + shape.CalculateArea());
//     Console.WriteLine();
// }
// Console.ReadLine();

//Indexer

// MyCollection collection = new MyCollection();
// collection[0] = "Hello";
// string value = collection[0];
// Console.WriteLine(value);

//Automatic Property

// Person p1 = new Person();
// p1.Name = "Neema";
// Console.WriteLine(p1.Name);

//ARRAYS


// Declaring an array of integers
class ArrayDemo
{
    public static void Main(String[] args)
    {
        int[] numbers = new int[5];

        // Initializing array elements
        numbers[0] = 10;
        numbers[1] = 20;
        numbers[2] = 30;
        numbers[3] = 40;
        numbers[4] = 50;

        // Accessing array elements
        Console.WriteLine(numbers[0]);  // Output: 10
        Console.WriteLine(numbers[2]);  // Output: 30

        // Iterating over array elements
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }

    }
}