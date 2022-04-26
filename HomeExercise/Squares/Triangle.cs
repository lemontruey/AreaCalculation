namespace HomeExercise.Squares
{
    internal sealed class Triangle : Shape
    {
        internal Triangle(IEnumerable<double> lengths) : base(lengths) { }

        internal override double GetArea()
        {
            // right triangle predicate
            if (Math.Pow(_lengths[0], 2) + Math.Pow(_lengths[1], 2) == Math.Pow(_lengths[2], 2))
                return 0.5d * _lengths[0] * _lengths[1];

            var halfPerimeter = _lengths.Aggregate(0.0d, (total, next) => total += next / 2);

            return Math.Sqrt(_lengths.Aggregate(halfPerimeter, (total, next) => total *= halfPerimeter - next));
        }
    }
}
