﻿using System;

/// <summary>
/// method that returns True if the object is an instance of a class
/// that inherits from the specified class, otherwise return False.
/// The object must be a subclass; your method cannot return True if the object is an instance
/// of the base class.
/// </summary>
class Obj
{
    /// <summary>
    /// return True if the object is an instance
    /// of the base class.
    /// </summary>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return derivedType.IsSubclassOf(baseType);
    }
}
