namespace _16._11._23
{
    internal interface IFigure
    {
        void MoveHorizontally(double x);
        void MoveVertically(double y);
        void ChangeColor(string color);
        string CheckVisibleOrInvisible();
        void GetInfo();
    }
}
