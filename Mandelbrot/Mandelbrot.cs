// Refactorlings by Producore
// © 2025 - All rights reserved

public class Complex(float R, float I)
{
  public static readonly Complex Zero =
    new(0, 0);

  public float R { get; } = R;
  public float I { get; } = I;

  public Complex Square()
  {
    return new(R * R - I * I,
      R * I * 2);
  }

  public float AbsSquared()
  {
    return I * I + R * R;
  }

  public static Complex operator +(
    Complex Left, Complex Right)
  {
    return new(Right.R + Left.R,
      Right.I + Left.I);
  }
}

public static class Mandelbrot
{
  public static bool TestEscape(
    Complex C, int M = 100000)
  {
    var Z = Complex.Zero;
    
    for (var S = 0; S < M; S++)
    {
      Z = C + Z.Square();

      if (Z.AbsSquared() > 4)
        return true;
    }

    return false;
  }
}