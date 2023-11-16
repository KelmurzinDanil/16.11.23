using System;

namespace _16._11._23
{
    internal class Circle : Point
    {
        internal double Radius;
        public override string CheckVisibleOrInvisible()
        {
            if (VisibleOrInvisible)
            {
                return "Visible";
            }
            else
            {
                return "Invisible";
            }
        }
        public override void GetInfo()
        {
            Console.WriteLine($"Цвет: {FigureColor} " +
                $"\nКоординаты:({HorizontallyCoordinate},{VerticallyCoordinate}) " +
                $"\nВидимость: {CheckVisibleOrInvisible()} " +
                $"\nПлощадь: {CalculateSquareCircle()} ");
        }
        double CalculateSquareCircle()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
        public Circle(double radius, string figureColor, bool visibleOrInvisible)
            : base(figureColor, visibleOrInvisible)
        {
            this.Radius = radius;
        }
    }
}
