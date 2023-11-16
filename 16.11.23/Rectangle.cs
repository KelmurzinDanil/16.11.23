using System;

namespace _16._11._23
{
    internal class Rectangle : Point
    {
        double A;
        double B;
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
                $"\nПлощадь: {CalculateSquareRectangle()} ");
        }
        double CalculateSquareRectangle()
        {
            return A * B;
        }
        public Rectangle(double a, double b, string figureColor, bool visibleOrInvisible)
            : base(figureColor, visibleOrInvisible)
        {
            A = a; B = b;
        }
    }
}
