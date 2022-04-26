namespace HomeExercise
{
    internal abstract class Shape
    {
        protected readonly double[] _lengths;

        protected Shape(IEnumerable<double> lengths)
        {
            _lengths = lengths.ToArray();
        }

        internal abstract double GetArea();
    }
}
