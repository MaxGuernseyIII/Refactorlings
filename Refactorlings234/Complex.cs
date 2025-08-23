// Refactorlings by Producore
// © 2025 - All rights reserved

readonly struct Complex(
  Real R,
  Imaginary I)
{
  readonly Real R = R;
  readonly Imaginary I = I;

  public static
    Complex operator *(
      Complex A,
      Complex B)
  {
    return A.R * B.R +
           A.R * B.I +
           A.I * B.R +
           A.I * B.I;
  }

  public static Complex
    operator +(Complex L,
      Complex R)
  {
    return new(
      L.R + R.R,
      L.I + R.I);
  }

  public static Complex
    operator +(Complex L,
      Real R)
  {
    return new(
      L.R + R,
      L.I);
  }

  public static Complex
    operator +(Complex L,
      Imaginary I)
  {
    return new(L.R,
      L.I + I);
  }

  public override
    string ToString()
  {
    return $"{R.V} + {I.V}i";
  }

  public void Deconstruct(
    out Real R,
    out Imaginary I)
  {
    R = this.R;
    I = this.I;
  }
}