// Refactorlings by Producore
// © 2025 - All rights reserved

class Real(float R)
{
  public float R { get; } = R;
}

class Imag(float I)
{
  public float I { get; } = I;
}

readonly struct Complex(
  Real R,
  Imag I)
{
  readonly Real R = R;
  readonly Imag I = I;

  public static
    Complex operator *(
      Complex L, Complex R)
  {
    return new(
      new(L.R.R * R.R.R -
          L.I.I * R.I.I),
      new(L.R.R * R.I.I +
          L.I.I * R.R.R));
  }

  public override
    string ToString()
  {
    return $"{R.R} + {I.I}i";
  }
}