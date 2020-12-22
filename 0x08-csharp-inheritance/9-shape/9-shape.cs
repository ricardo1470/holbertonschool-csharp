using System;

/// <summary>a class Shape.</summary>
class Shape
{
    /// <summary>public method: public virtual int Area()</summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

/// <summary>a class Rectangle that inherits from Shape</summary>
class Rectangle : Shape {
    ///<summary>private int width </summary>
    private int width;

    ///<summary>private int height </summary>
    private int height;

    /// <summary>public int Width</summary>
    public int Width {
        get
        {
            return (width);
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Width must be greater than or equal to 0");
            }
            else
            {
                width = value;
            }
        }
    }

    /// <summary>public property</summary>
    public int Height {
        get
        {
            return (height);
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Height must be greater than or equal to 0");
            }
            else
            {
                height = value;
            }
        }
    }

    /// <summary>will override the Area() method defined in the Shape base class.</summary>
    public new int Area()
    {
        return (height * width);
    }

    /// <summary>public override string ToString().</summary>
    public override string ToString()
    {
        return (string.Format("[Rectangle] {0} / {1}", width, height));
    }
}

/// <summary>write a class Square that inherits from Rectangle</summary>
class Square : Rectangle {
    /// <summary>private field</summary>
    private int size;

    /// <summary>public property</summary>
    public int Size
    {
        get
        {
            return (size);
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Size must be greater than or equal to 0");
            }
            else
            {
                size = Height = Width = value;
            }
        }
    }

    /// <summary>method within your Square class</summary>
    public override string ToString()
	{
		return String.Format("[Square] {0} / {0}", size);
	}
}
