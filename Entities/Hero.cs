namespace DIO_OOP.Entities;
public abstract class Hero
{
    public string Name { get; set; }
    public int Level { get; set; }
    public string HeroType { get; set; }

    public Hero(string name, int level, string heroType)
    {
        this.Name = name;
        this.Level = level;
        this.HeroType = heroType;
    }

    public virtual string Attack()
    {
        return $"{this.Name} Atacou!";
    }

    public override string ToString()
    {
        return $" Name: {this.Name}\n Level: {this.Level}\n Hero Type: {this.HeroType}";
    }
}