// Refactorlings by Producore
// © 2025 - All rights reserved

record Complex(
  float R,
  float I)
{
  public static
    Complex
    operator *(
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