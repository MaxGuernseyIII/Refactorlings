namespace Refactorlings;

record Complex(double R, double I)
{
  public static Complex operator +(
    Complex Left, Complex Right)
  {
    return new(
      Left.R + Right.R, 
      Left.I + Right.I);
  }

  public static Complex operator -(
    Complex Left, 
    Complex Right)
  {
    return new(
      Left.R - Right.R, 
      Left.I - Right.I);
  }

  public static Complex operator *(
    Complex Left, Complex Right)
  {
    return new(
      Left.R * Right.R - Left.I * Right.I,
      Left.R * Right.I + Left.I * Right.R);
  }

  public static Complex operator /(
    Complex Left, Complex Right)
  {
    var Denominator = Right.R * Right.R + 
                      Right.I * Right.I;
    return new(
      (Left.R * Right.R + 
       Left.I * Right.I) / Denominator,
      (Left.I * Right.R - 
       Left.R * Right.I) / Denominator
    );
  }

  public static implicit operator Complex(
    double R)
  {
    return new(R, 0);
  }
}