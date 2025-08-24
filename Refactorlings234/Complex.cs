// Refactorlings by Producore
// © 2025 - All rights reserved

class Real(float V)
{
  public float V { get; } = V;
}

class Imaginary(float V)
{
  public float V { get; } = V;
}

readonly struct Complex
{
  readonly Real R;
  readonly Imaginary I;

  public Complex(
    Real R,
    Imaginary I)
  {
    this.R = R;
    this.I = I;
  }

  public static
    Complex operator *(
      Complex L, Complex R)
  {
    return new(new(
        L.R.V * R.R.V -
        L.I.V * R.I.V),
      new(L.R.V * R.I.V +
          L.I.V * R.R.V));
  }

  public override
    string ToString()
  {
    return $"{R.V} + {I.V}i";
  }
}