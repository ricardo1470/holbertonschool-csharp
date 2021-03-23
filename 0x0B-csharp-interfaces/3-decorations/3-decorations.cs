using System;

/// <summary>abstract class called Base</summary>
public abstract class Base
{
    /// <summary>property</summary>
    public string name { set; get; }

    /// <summary>abstract class called Base</summary>
    public override string ToString()
    {
        return $"{this.name} is a {this.GetType().Name}";
    }
}


/// <summary>an interface called IInteractive</summary>
interface  IInteractive
{
    void Interact();
}

/// <summary>an interface called IBreakable</summary>
interface IBreakable
{
    int durability { get; set; }
    void Break();
}

/// <summary>an interface called IBreakable</summary>
interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();
}

/// <summary>class called Door</summary>
class Door : Base, IInteractive
{
    /// <summary>constructor that sets the value of name.</summary>
    public Door(string name = "Door")
    {
        this.name = name;
    }

    /// <summary>Interaction with a door.</summary>
    public void Interact()
    {
        Console.WriteLine($"You try to open the {this.name}. It's locked.");
    }
}

/// <summary>class Decoration</summary>
public class Decoration : Base, IInteractive, IBreakable
{
    ///<summary>Property isQuestItem</summary>
    public bool isQuestItem;
    ///<summary>Property durability</summary>
    public int durability { get; set; }

    /// <summary>Constructor.</summary>
    public Decoration (string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability <= 0)
        {
            throw new Exception("Durability must be greater than 0");
        }
        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }

    ///<summary>Method Interact</summary>
    public void Interact()
    {
        if (durability <= 0)
        {
            Console.WriteLine($"The {this.name} has been broken");
        }
        else if (isQuestItem == true)
        {
            Console.WriteLine($"You look at the {this.name}. There's a key inside.");
        }
        else if (isQuestItem == false)
        {
            Console.WriteLine($"You look at the {this.name}. Not much to see here.");
        }
    }

    ///<summary>Method Break</summary>
    public void Break()
    {
        durability--;

        if (durability > 0)
        {
            Console.WriteLine($"You hit the {this.name}. It cracks.");
        }
        if (durability == 0)
        {
            Console.WriteLine($"You smash the {this.name}. What a mess.");
        }
        if (durability < 0)
        {
            Console.WriteLine($"The {this.name} is already broken.");
        }
    }

}