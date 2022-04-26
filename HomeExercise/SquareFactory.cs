namespace HomeExercise
{
    using HomeExercise.Squares;
    internal static class SquareFactory
    {
        internal static Shape CreateShape(double[] parameters) =>
            parameters.Length switch
            {
                1 => new Circle(parameters),
                3 => new Triangle(parameters),
                _ => throw new InvalidCastException()
            };
    }
}