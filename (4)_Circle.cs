namespace lab5
{
    class Circle : Figure
    {
        protected uint radius;
        public Circle(uint radius)
        {
            this.radius=radius;
        }

        public override double Area()
        {
            return Math.PI * radius * radius;
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * radius;
        }
    }
}
