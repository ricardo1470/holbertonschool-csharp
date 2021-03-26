using System;

///<summary> enum Modifier </summary>
public enum Modifier
{
    /// <summary>value Weak</summary>
    Weak,
    /// <summary>value Base</summary>
    Base,
    /// <summary>value Strong</summary>
    Strong
};

/// <summary> delegate </summary>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

/// <summary> Class Player </summary>
class Player
{
    private string name;
    private float maxHp;
    private float hp;
    private string status;
    public EventHandler<CurrentHPArgs> HPCheck;

    /// <summary> Constructor Player</summary>
    public Player(string name = "Player", float maxHp = 100f)
    {
        this.name = name;
        if (maxHp > 0)
        {
            this.maxHp = maxHp;
        }
        else
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            this.maxHp = 100f;
        }
        this.hp = this.maxHp;

        this.status = $"{name} is ready to go!";

        HPCheck += CheckStatus;
    }

    /// <summary>
    /// Method that prints health of player.
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }

    ///<summary> Method damage player</summary>
    public void TakeDamage(float damage)
    {
        if (damage < 0)
        {
            damage = 0;
        }
        Console.WriteLine($"{name} takes {damage} damage!");
        ValidateHP(hp - damage);
    }

    ///<summary> Method healt player</summary>
    public void HealDamage(float heal)
    {
        if (heal < 0)
        {
            heal = 0;
        }
        Console.WriteLine($"{name} heals {heal} HP!");
        ValidateHP(hp + heal);
    }

    ///<summary> Method validate hp player</summary>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
        {
            this.hp = 0f;
        }
        else if (newHp > maxHp)
        {
            this.hp = this.maxHp;
        }
        else
        {
            this.hp = newHp;
        }
        HPCheck(this, new CurrentHPArgs(hp));
    }

    ///<summary> Method ApplyModifier player</summary>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if (modifier == Modifier.Weak)
        {
            return baseValue / 2;
        }
        if (modifier == Modifier.Strong)
        {
            return baseValue * 1.5f;
        }
        return baseValue;
    }

    ///<summary> Method CheckStatus player</summary>
    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == maxHp)
        {
            status = $"{name} is in perfect health!";
        }
        else if (e.currentHp >= maxHp / 2)
        {
            status = $"{name} is doing well!";
        }
        else if (e.currentHp >= maxHp / 4)
        {
            status = $"{name} isn't doing too great...";
        }
        else if (e.currentHp > 0)
        {
            status = $"{name} needs help!";
        }
        else
        {
            status= $"{name} is knocked out!";
        }
        Console.WriteLine(status);
    }

    ///<summary> Method HPValueWarning player</summary>
    private void HPValueWarning(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == 0)
        {
            Console.WriteLine("Health has reached zero!");
        }
        else
        {
            Console.WriteLine("Health is low!");
        }
    }

    ///<summary> Method OnCheckStatus player</summary>
    private void OnCheckStatus(CurrentHPArgs e)
    {
        if (e.currentHp < (this.maxHp / 4))
        {
            HPCheck += HPValueWarning;
        }
        HPCheck(this, e);
    }
}

///<summary> EventArgs class </summary>
class CurrentHPArgs : EventArgs
{
    public readonly float currentHp;

    /// <summary>Method CurrentHPArgs player</summary>
    public CurrentHPArgs(float newHp)
    {
        this.currentHp = newHp;
    }
}
