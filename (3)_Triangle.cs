
namespace lab5
{
    class Triangle : Figure
    {
        protected uint a, b, c;
        public Triangle(uint a, uint b, uint c)
        {
            this.a = a; this.b = b; this.c = c;
        }
        public override double Area()
        {
            return Math.Sqrt(Perimeter()/2 * ((Perimeter()/2 - a) * (Perimeter()/2 - b) * (Perimeter()/2 - c)));
        }

        public override double Perimeter()
        {
            return a+b+c;
        }
        
       
    }
}
