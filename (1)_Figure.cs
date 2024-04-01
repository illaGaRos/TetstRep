namespace lab5
{
     abstract class Figure
     {
        abstract public double Area();
        abstract public double Perimeter();
        public void FigureInfo() 
        {
            Console.WriteLine("Type of figure " + GetType().Name);
            Console.WriteLine("Area = " + Area());
            Console.WriteLine("Perimeter = " + Perimeter());
        }
    }
}
