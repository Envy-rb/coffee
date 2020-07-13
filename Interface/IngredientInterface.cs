using System;
using System.Collections.Generic;
using System.Text;

namespace kolyaKurs.entity
{
    public interface IngredientInterface
    {
        string Name { get; }
        double Price { get; }
        string IngredientType { get; }
    }
}
