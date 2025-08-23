// Refactorlings by Producore
// © 2025 - All rights reserved

readonly record struct
  Complex(float R, float I)
{
  public float R { get; } = R;
  public float I { get; } = I;

  public static
    Complex operator *(
      Complex Left,
      Complex Right)
  {
    return new(
      Left.R * Right.R -
      Left.I * Right.I,
      Left.R * Right.I +
      Left.I * Right.R);
  }
}