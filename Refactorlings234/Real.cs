// Refactorlings by Producore
// © 2025 - All rights reserved

class Real(float V)
{
  public float V { get; } = V;

  public static Real operator
    *(
      Real LeftR,
      Real RightR
    )
  {
    return new(LeftR.V *
               RightR.V);
  }

  public static Real operator
    +(
      Real Real1,
      Real Real2
    )
  {
    return new(Real1.V +
               Real2.V);
  }

  public static Complex
    operator +(
      Imaginary Imaginary,
      Real Real)
  {
    return new(
      Real, Imaginary);
  }

  public static Complex
    operator +(Real Real,
      Imaginary Imaginary)
  {
    return new(
      Real, Imaginary);
  }
}