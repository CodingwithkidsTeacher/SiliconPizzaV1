using SiliconPizza.Models;
using System.Collections.Generic;

namespace SiliconPizza.ViewModels
{
    public class PizzasListViewModel
    {
        public IEnumerable<Pizza> Pizzas { get; set; }
        public string CurrentCategory { get; set; }
    }
}

