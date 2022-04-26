namespace HomeExercise.Squares
{
    internal sealed class Circle : Shape
    {
        internal Circle(IEnumerable<double> lengths) : base(lengths) { }

        internal override double GetArea()
        {
            var r = _lengths[0];
            return Math.PI * r * r;
        }
    }
}
