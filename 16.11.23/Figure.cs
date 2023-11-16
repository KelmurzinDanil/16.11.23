namespace _16._11._23
{

    abstract class Figure : IFigure
    {
        protected double HorizontallyCoordinate;
        protected double VerticallyCoordinate;
        protected string FigureColor;
        protected bool VisibleOrInvisible;


        public void MoveHorizontally(double x)
        {
            HorizontallyCoordinate += x;
        }
        public void MoveVertically(double y)
        {
            VerticallyCoordinate += y;
        }
        public void ChangeColor(string color)
        {
            FigureColor = color;
        }
        public abstract string CheckVisibleOrInvisible();
        public abstract void GetInfo();




    }
}
