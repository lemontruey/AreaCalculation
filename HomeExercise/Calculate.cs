namespace HomeExercise
{
    public static class Calculate
    {
        public static double GetSquare(params double[] lengths)
        {
            if (lengths.Length < 1 || lengths.Any(l => l < 1)) return 0.0d;

            return Math.Round(SquareFactory.CreateShape(lengths).GetArea(), 5);
        }
    }
}
