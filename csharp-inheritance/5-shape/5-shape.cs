using System;
using System.Collections.Generic;

class Shape
{
    public virtual int Area()
    {
        throw NotImplementedException("Area() is not implemented");
    }
}