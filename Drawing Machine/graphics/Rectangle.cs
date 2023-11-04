namespace graphics;

public class Rectangle : AbstractGraphic2D
{

    public Rectangle(decimal left, decimal top, decimal width, decimal height)
    {
        Left = left;
        Top = top;
        Width = width;
        Height = height;
    }

    public override decimal LowerBoundX
    {
        get => Left;
    }

    public override decimal UpperBoundY
    {
        get => Top + Height;
    }

    public override decimal LowerBoundY
    {
        get => Top;
    }

    public override decimal UpperBoundX
    {
        get => Left + Width;
    }
    public decimal Left { get; set; }
    public decimal Top { get; set; }
    public decimal Width { get; set; }
    public decimal Height { get; set; }

    public override bool ContainsPoint(decimal x, decimal y)
    {
        if ((x <= UpperBoundX && x>=LowerBoundX)&& (y <= UpperBoundY&&y>=LowerBoundY))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}