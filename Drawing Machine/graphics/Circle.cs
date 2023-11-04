namespace graphics;

public class Circle : AbstractGraphic2D
{
    public Circle(int centerX, int centerY, decimal radius)
    {
        CenterX = centerX;
        CenterY = centerY;
        Radius = radius;
    }

    public override decimal LowerBoundX
    {
        get => CenterX - Radius;
    }

    public override decimal UpperBoundX
    {
        get => (CenterX + Radius);
    }

    public override decimal LowerBoundY
    {
        get => (CenterY - Radius);
    }

    public override decimal UpperBoundY
    {
        get => (CenterY + Radius);

    }

    public decimal CenterX { get; set; }
    public decimal CenterY { get; set; }
    public decimal Radius { get; set; }
    

    public override bool ContainsPoint(decimal x, decimal y)
    {
         
        
        if (Math.Sqrt((double)((CenterX-x)*(CenterX-x))+(double)((CenterY-y)*(CenterY-y)))<=(double)Radius)
        {
            return true;
        }
        else
        {
            
            return false;
        }
    }
}
