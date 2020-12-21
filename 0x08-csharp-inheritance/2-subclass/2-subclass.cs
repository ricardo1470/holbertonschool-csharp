using System;


class Obj
{
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        if (derivedType.BaseType == baseType)
        {
            return (true);
        }
        return (false);
    }
}
