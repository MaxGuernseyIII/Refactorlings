// Refactorlings by Producore
// © 2025 - All rights reserved

class Imaginary(float V)
{
  public float V { get; } = V;

  public static Real operator
    *(
      Imaginary LeftI,
      Imaginary RightI)
  {
    var Result =
      new Real(-LeftI.V *
               RightI.V);
    return Result;
  }

  public static Imaginary
    operator *(
      Real L, Imaginary R
    )
  {
    return new(L.V * R.V);
  }

  public static Imaginary
    operator *(Imaginary I,
      Real R)
  {
    return new(I.V * R.V);
  }

  public static Imaginary
    operator +(Imaginary I1,
      Imaginary I2)
  {
    return new(
      I1.V +
      I2.V);
  }
}