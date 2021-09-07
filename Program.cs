using System;
using System.Collections.Generic;


namespace QuiltShape
{
    class Program
    {
        public static string Name { get; private set; }

        static void Main(string[] args)
        {


            List<Shape> shapes = new();


            string userInput = Console.ReadLine().ToLower();

            
            Console.WriteLine("Welcome to Stephen's Quilt Application");

            while (userInput != "e" || userInput != "exit")
            {
                UI.MenuSelection();


                userInput = Console.ReadLine().ToLower();
                switch (userInput)
                {
                    case "s":
                    case "square":
                        Square s1 = new Square();
                        s1.Name = "Square";
                        Console.WriteLine("You selected a " + s1.Name);
                        Console.WriteLine("Select a color for your square");
                        s1.Color = Console.ReadLine();
                        Console.WriteLine("Enter the length");
                        s1.Side1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("The area of the square is " + s1.TotalArea());
                        shapes.Add(s1);
                        break;


                    case "t":
                    case "triangle":
                        Triangle t1 = new Triangle();
                        t1.Name = "Triangle";
                        Console.WriteLine("You selected a " + t1.Name);
                        Console.WriteLine("Select a color for your triangle");
                        t1.Color = Console.ReadLine();
                        Console.WriteLine("Enter the length of side A");
                        t1.Side1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the length of side B");
                        t1.Side2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the length of side C");
                        t1.Side3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("The area of the triangle is " + t1.TotalArea());
                        shapes.Add(t1);
                        break;


                    case "r":
                    case "rectangle":
                        Rectangle r1 = new Rectangle();
                        r1.Name = "Rectangle";
                        Console.WriteLine("You selected a rectangle");
                        Console.WriteLine("Select a color for your rectangle");
                        r1.Color = Console.ReadLine();
                        Console.WriteLine("Enter the length");
                        r1.Side1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the width");
                        r1.Side2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("The area of the rectangle is " + r1.TotalArea());
                        shapes.Add(r1);
                        break;


                    case "l":
                    case "list":
                        Console.WriteLine("\n\n");
                        Console.WriteLine("List of shapes");
                        Console.WriteLine("--------------");

                        foreach (var shape in shapes)
                        {
                            Console.WriteLine($"{shape.Color} {shape.Name} with total area of {shape.TotalArea()}.");
                            Console.WriteLine("--------------");
                        }
                        break;


                    case "c":
                    case "clear":
                        Console.WriteLine("Are you sure you want to clear list? (y) for yes or any key to cancel");
                        string inputClear = Console.ReadLine();
                        if (inputClear == "y")
                        {
                            shapes.Clear();
                            break;
                        }
                        break;


                    case "e":
                    case "exit":
                        Console.Clear();
                        Environment.Exit(0);
                        break;


                    default:
                        Console.WriteLine("Please enter the correct selection");
                        break;


                }

                Console.ReadKey();
            }
        }
    }
}
