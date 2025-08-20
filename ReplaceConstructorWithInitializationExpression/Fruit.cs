namespace ReplaceConstructorWithInitializationExpression;

record Fruit
{
  public Fruit(string Name, double SizeInInches, double SugarInGrams, string Saying)
  {
    this.Name = Name;
    this.SizeInInches = SizeInInches;
    this.SugarInGrams = SugarInGrams;
    this.Saying = Saying;
  }

  public string Name { get; set; }
  public double SizeInInches { get; set; }
  public double SugarInGrams { get; set; }
  public string Saying { get; set; }
}