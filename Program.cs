using System;
using task8.Interface;
namespace task8
{
    class Program
    {
        static void Main()
        {
            #region P1
            //IVehicle car = new Car();
            //IVehicle bike = new Bike();

            //car.StartEngine();
            //car.StopEngine();

            //bike.StartEngine();
            //bike.StopEngine();
            //Q1:
            //Because the code becomes loosely coupled and more flexible.
            #endregion
            #region P2
            //Shape rectangle = new Rectangle(5, 4);
            //Shape circle = new Circle(3);

            //rectangle.Display();
            //Console.WriteLine(rectangle.GetArea());

            //circle.Display();
            //Console.WriteLine(circle.GetArea());
            //Q2:
            //Prefer an abstract class when related classes:
            //Have a strong "is-a" relationship.
            //Share common data.
            //Share common implementation.
            //Need constructors or protected members.
            //Need a common base identity.
            #endregion
            #region P3
            //Product[] products =
            //{
            //new Product(1, "Laptop", 30000),
            //new Product(2, "Mouse", 500),
            //new Product(3, "Keyboard", 1200)
            //};

            //Array.Sort(products);

            //foreach (Product product in products)
            //{
            //    Console.WriteLine(product);
            //}
            //Q3:
            //IComparable allows the class to define its default / natural ordering.
            //Without IComparable, we would need to provide comparison logic separately.
            #endregion
            #region P4
            //Student student1 = new Student(1, "Ahmed", 90);

            //Student student2 = new Student(student1);

            //student2.Name = "Mohamed";

            //Console.WriteLine(student1.Name);
            //Console.WriteLine(student2.Name);
            //Q4:
            //A copy constructor creates a new object initialized using the values of another object.
            #endregion
            #region P5
            //Robot robot = new Robot();
            //robot.Walk();

            //IWalkable walkable = robot;
            //walkable.Walk();
            //Q5:
            //It allows a class to provide a different implementation of the same method depending on how the object is accessed.
            //This is especially useful when a class implements multiple interfaces that contain members with the same names.
            #endregion
            #region P6
            //Account account = new Account();

            //account.Id = 101;
            //account.Holder = "Ahmed";
            //account.AccountBalance = 5000;

            //Console.WriteLine(account.Id);
            //Console.WriteLine(account.Holder);
            //Console.WriteLine(account.AccountBalance);
            //Q6,Q7:
            //Abstraction focuses on hiding unnecessary implementation details and exposing essential functionality,
            //while encapsulation focuses on bundling data and methods together and controlling access to the internal state.
            #endregion
            #region P7
            //Book book1 = new Book();
            //Book book2 = new Book("Clean Code");
            //Book book3 = new Book("The Pragmatic Programmer", "Andrew Hunt"); 
            //Console.WriteLine($"Book 1: {book1.Title} - {book1.Author}"); 
            //Console.WriteLine($"Book 2: {book2.Title} - {book2.Author}"); 
            //Console.WriteLine($"Book 3: {book3.Title} - {book3.Author}");
            //Q8:
            //Constructor overloading improves class usability by allowing objects to be initialized in different ways
            //using different sets of parameters, providing flexibility and convenience to the programme
            #endregion
            #region Program
            // PART 1: Test Shape Series //
            Console.WriteLine("========== PART 1 =========="); 
            IShapeSeries squareSeries = new SquareSeries(); 
            Console.WriteLine("Square Series:"); 
            PrintTenShapes(squareSeries); 
            IShapeSeries circleSeries = new CircleSeries(); 
            Console.WriteLine("\nCircle Series:"); 
            PrintTenShapes(circleSeries); 
            // PART 2: Test Shape Sorting //
            Console.WriteLine("\n========== PART 2 =========="); 
            Shape1[] shapes = { 
                new Shape1("Square", 25),
                new Shape1("Circle", 12.5),
                new Shape1("Rectangle", 40), 
                new Shape1("Circle", 30), 
                new Shape1("Square", 9) 
            }; 
            // Sort shapes by Area using IComparable
            Array.Sort(shapes);
            Console.WriteLine("Shapes sorted by area:"); 
            foreach (Shape1 shape in shapes) 
            { 
                Console.WriteLine($"{shape.Name} - {shape.Area}"); 
            }
            // PART 3: Test Geometric Shape Hierarchy //
            Console.WriteLine("\n========== PART 3 ==========");

            Triangle triangle = new Triangle();

            triangle.Dimension1 = 10;
            triangle.Dimension2 = 5;

            Console.WriteLine("Triangle:");
            Console.WriteLine($"Area = {triangle.CalculateArea()}");
            Console.WriteLine($"Perimeter = {triangle.Perimeter}");


            // Create Rectangle GeometricShape
            Rectangle1 rectangle = new Rectangle1();

            rectangle.Dimension1 = 10;
            rectangle.Dimension2 = 5;

            Console.WriteLine("\nRectangle:");
            Console.WriteLine($"Area = {rectangle.CalculateArea()}");
            Console.WriteLine($"Perimeter = {rectangle.Perimeter}");
            // PART 4: Test Selection Sort // 
            Console.WriteLine("\n========== PART 4 ==========");
            // Shape areas generated in Part 2
            int[] shapeAreas = 
                { 
                (int)shapes[0].Area, 
                (int)shapes[1].Area, 
                (int)shapes[2].Area, 
                (int)shapes[3].Area, 
                (int)shapes[4].Area 
                }; 
            Console.WriteLine("Before Selection Sort:"); 
            foreach (int area in shapeAreas) 
            { 
                Console.Write(area + " "); 
            } 
            // Sort using our own SelectionSort method
            SelectionSort(shapeAreas); 
            Console.WriteLine("\n\nAfter Selection Sort:"); 
            foreach (int area in shapeAreas) 
            { 
                Console.Write(area + " "); 
            }
            #endregion
        }
        // Method to print the first ten areas of shapes in a series
        public static void PrintTenShapes(IShapeSeries series)
        {
            series.ResetSeries();

            for (int i = 0; i < 10; i++)
            {
                series.GetNextArea(); Console.WriteLine(series.CurrentShapeArea);
            }

        }
        public static void SelectionSort(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {  
                int minIndex = i; 
                for (int j = i + 1; j < numbers.Length; j++) 
                { 
                    if (numbers[j] < numbers[minIndex]) { minIndex = j; }
                } 
                int temp = numbers[i]; 
                numbers[i] = numbers[minIndex]; 
                numbers[minIndex] = temp; 
            } 
        }
    }
}