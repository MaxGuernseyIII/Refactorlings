// Refactorlings by Producore
// © 2025 - All rights reserved

record Position
{
  public override
    string ToString()
  {
    return
      $"{Line},{Col}";
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
}