using System;

abstract class Base
{
    public string name = null;

    /// <summary>
    /// abstract class called Base
    /// </summary>
    public override string ToString()
    {
        return name + " is a " + this.GetType();
    }
}


/// <summary>
/// an interface called IInteractive
/// </summary>
interface  IInteractive
{
    void Interact();
}

/// <summary>
///  an interface called IBreakable
/// </summary>
interface IBreakable
{
    int durability { get; set; }
    void Break();
}

/// <summary>
///  an interface called IBreakable
/// </summary>
interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();
}

/// <summary>
/// class called Door
/// </summary>
class Door : Base, IInteractive
{
    /// <summary>
    /// constructor that sets the value of name.
    /// </summary>
    public Door(string name = "Door")
    {
        this.name = name;
    }

    /// <summary>
    /// Interaction with a door.
    /// </summary>
    public void Interact()
    {
        Console.WriteLine($"You try to open the {this.name}. It's locked.");
    }
}