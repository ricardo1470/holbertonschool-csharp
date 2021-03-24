using System;

/// <summary>
/// abstract class called Base
/// </summary>
public abstract class Base
{
    /// <summary>property</summary>
    private string name { get; set; }

    /// <summary>abstract class called Base</summary>
    public override string ToString()
    {
        return $"{this.name} is a {this.GetType().Name}";
    }
}

/// <summary>an interface called IInteractive</summary>
public interface IInteractive
{
    /// <summary>method Interact</summary>
    void Interact();
}

/// <summary>an interface called IBreakable</summary>
public interface IBreakable
{
    /// <summary>property durability</summary>
    int durability { get; set; }
    /// <summary>method Break</summary>
    void Break();
}

/// <summary>an interface called IBreakable</summary>
public interface ICollectable
{
    /// <summary>property isCollected</summary>
    bool isCollected { get; set; }
    /// <summary>method Collect</summary>
    void Collect();
}

/// <summary>new class called TestObject</summary>
public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    ///<summary>Property durability</summary>
    public int durability { get; set; }
    ///<summary>Property isCollected</summary>
    public bool isCollected { get; set; }
    ///<summary>Property isCollected</summary>
    public string name { get; set; }

    ///<summary>Method Interact</summary>
    public void Interact() {}
    ///<summary>Method Break</summary>
    public void Break() {}
    ///<summary>Method Collect</summary>
    public void Collect() {}
}
