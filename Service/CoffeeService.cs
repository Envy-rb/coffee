using kolyaKurs.entity;
using System.Collections.Generic;
using System.ComponentModel;

namespace kolyaKurs.Service
{
    class CoffeeService
    {
        BindingList<CoffeeCup> coffeeCups = new BindingList<CoffeeCup>();
        public void addCoffeeCup(CoffeeCup coffeeCup) => coffeeCups.Add(coffeeCup);

        public void removeCoffeeCup(int index) => coffeeCups.RemoveAt(index);

        public void removeCoffeeCup(CoffeeCup item) => coffeeCups.Remove(item);

        public BindingList<CoffeeCup> CoffeeCups => coffeeCups;
    }
}
