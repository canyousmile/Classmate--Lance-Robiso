public abstract class HumanCharacter
{
    public string FullName { get; private set; }
    public string Trait { get; private set; }

    protected HumanCharacter(string fullName, string trait)
    {
        FullName = fullName;
        Trait = trait;
    }

    public virtual string Introduce()
    {
        return $"Hi, I'm {FullName}. People say I'm {Trait}!";
    }
}
