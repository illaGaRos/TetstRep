namespace lab5
{
    class Rectangle : Figure
    {
        protected uint a, b;
        public Rectangle(uint a, uint b)
        {
            this.a = a; this.b = b;
        }
        public override double Area()
        {
            return a*b;
        }

        public override double Perimeter()
        {
            return 2*a + 2*b;
        }

        
    }
}
