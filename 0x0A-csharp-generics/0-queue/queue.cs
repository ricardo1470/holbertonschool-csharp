using System;

/// <summary>
/// new class called Queue.
///</summary>
class Queue<T>
{
    /// <summary>
    /// Queue should not inherit from other classes or interfaces.
    ///</summary>
    /// <return> the Queue’s type.</return>
    public Type CheckType()
    {
        return typeof(T);
    }
}
