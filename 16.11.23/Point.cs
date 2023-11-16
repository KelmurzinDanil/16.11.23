using System;

namespace _16._11._23
{
    internal class Point : Figure
    {
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
                $"\nКоординаты:({HorizontallyCoordinate},{VerticallyCoordinate})" +
                $"\nВидимость: {CheckVisibleOrInvisible()} ");
        }
        public Point(string figureColor, bool visibleOrInvisible)
        {
            HorizontallyCoordinate = 0;
            VerticallyCoordinate = 0;
            FigureColor = figureColor;
            VisibleOrInvisible = visibleOrInvisible;
        }
    }
}
