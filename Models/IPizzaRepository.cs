﻿using System.Collections.Generic;

namespace SiliconPizza.Models
{
    public interface IPizzaRepository
    {
        IEnumerable<Pizza> AllPizzas { get; }
        IEnumerable<Pizza> PizzasOfTheWeek { get; }

        Pizza GetPizzaById(int pizzaId);
    }
}
