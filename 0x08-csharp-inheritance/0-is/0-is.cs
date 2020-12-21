using System;

/// <summary>
/// method that returns True if the object is an int,
/// otherwise return False
/// </summary>
class Obj
{
    /// <summary>
    /// returns True if the object is an int
    /// otherwise return False.
    /// </summary>
    public static bool IsOfTypeInt(object obj)
    {
        if (obj.GetType() == typeof(int))
        {
            return (true);
        }
        return (false);
    }
}
