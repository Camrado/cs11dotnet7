namespace Packt.Shared;

public struct DisplacementVector {
    public int X { get; set; }
    public int Y { get; set; }

    public DisplacementVector(int initialX, int initialY) {
        X = initialX;
        Y = initialY;
    }

    public static DisplacementVector operator +(DisplacementVector vector1, DisplacementVector vector2) {
        return new(vector2.X + vector1.X, vector2.Y + vector1.Y);
    }
}