// Refactorlings by Producore
// © 2025 - All rights reserved

readonly struct Complex
{
  readonly float I;
  readonly float R;

  public Complex(float R, float I)
  {
    this.I = I;
    this.R = R;
  }

  public static
    Complex operator *(
      Complex L, Complex R)
  {
    return new(
      L.R * R.R - L.I * R.I,
      L.R * R.I + L.I * R.R);
  }

  public override 
    string ToString()
  {
    return $"{R} + {I}i";
  }
}