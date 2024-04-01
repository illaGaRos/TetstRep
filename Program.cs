namespace lab5
{
     class Program
    {
        static void Main()
        {
            Figure[] figures = new Figure[3]; 

            for (int i = 0; i < figures.Length; i++)
            {
                Console.WriteLine("Choose type of figure 1 - Rectangle 2 - Triangle 3 - Circle ");

                uint.TryParse(Console.ReadLine(), out uint type);

                switch (type)
                {
                    case 1:
                        Console.WriteLine("Enter length and width of the rectangle");

                        Console.Write("Length = ");
                        uint.TryParse(Console.ReadLine(), out uint length);

                        Console.Write("Width = ");
                        uint.TryParse(Console.ReadLine(), out uint width);

                        figures[i] = new Rectangle(length, width);

                        figures[i].Area();
                        figures[i].Perimeter();
                        figures[i].FigureInfo();

                        Console.WriteLine("Press any cay to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 2:
                        Console.WriteLine("Enter lengths of the sides of the triangle");

                        Console.Write("First side = ");
                        uint.TryParse(Console.ReadLine(), out uint a);

                        Console.Write("Second side = ");
                        uint.TryParse(Console.ReadLine(), out uint b);

                        Console.Write("Third side = ");
                        uint.TryParse(Console.ReadLine(), out uint c);

                        figures[i] = new Triangle(a,b,c);

                        figures[i].Area();
                        figures[i].Perimeter();
                        figures[i].FigureInfo();
                        Console.WriteLine("Press any cay to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 3:
                        Console.WriteLine("Enter radius of the circle");

                        Console.Write("Radius = ");
                        uint.TryParse(Console.ReadLine(), out uint radius);

                        figures[i] = new Circle(radius);

                        figures[i].Area();
                        figures[i].Perimeter();
                        figures[i].FigureInfo();
                        Console.WriteLine("Press any cay to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }
    }
}