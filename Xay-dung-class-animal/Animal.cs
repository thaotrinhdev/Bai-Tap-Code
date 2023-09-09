public abstract class Animal
{
    protected string Weigth{ get;set;}
    protected string Height {get; set;}
    public Animal(string weight, string height)
    {
        this.Weigth= weight;
        this.Height = height;
    }
    public abstract void PrintInfo();

}
class Cat: Animal
{
    private string Name{get;set;}
    public Cat(string weight, string height, string name): base(weight,height)
    {
        this.Name= name;

    }
    public override void PrintInfo()
    {
        Console.WriteLine("Weight : {0}" + '\n' + "Height: {1}" + '\n' + "Name: {2}", this.Weigth, this.Height, this.Name);
    }
}