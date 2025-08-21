// Refactorlings by Producore
// Copyright 2025-2025
// All rights reserved.

record Position(
  int Col,
  int Line)
{
  public override
    string ToString()
  {
    return
      $"{Line},{Col}";
  }
}