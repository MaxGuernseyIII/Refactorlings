record Position
{
  public Position(
    int Col,
    int Line)
  {
    this.Col = Col;
    this.Line = Line;
  }

  public int Col
  {
    get;
    init;
  }

  public int Line
  {
    get;
    init;
  }

  public override
    string ToString()
  {
    return
      $"{Line},{Col}";
  }
}