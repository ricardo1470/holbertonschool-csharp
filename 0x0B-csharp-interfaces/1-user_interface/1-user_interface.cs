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
/// new class called TestObject
/// </summary>
class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    public int durability { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public bool isCollected { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void Interact()
    {
        throw new NotImplementedException();
    }
    public void Break()
    {
        throw new NotImplementedException();
    }

    public void Collect()
    {
        throw new NotImplementedException();
    }
}
