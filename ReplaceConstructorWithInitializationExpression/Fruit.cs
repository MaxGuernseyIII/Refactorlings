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

  public string Name { get; private set; }
  public double SizeInInches { get; private set; }
  public double SugarInGrams { get; private set; }
  public string Saying { get; private set; }
}