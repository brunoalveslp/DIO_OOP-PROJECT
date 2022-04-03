namespace DIO_OOP.Entities;

public class Knight : Hero {
    public Knight(string name, int level, string heroType) : base(name,level,heroType){}

    public override string Attack()
    {
        return $"{this.Name} Atacou Com Sua Espada!";
    }
}