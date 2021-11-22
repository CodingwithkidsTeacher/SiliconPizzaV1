using SiliconPizza.Models;
using System.Collections.Generic;

namespace SiliconPizza.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Pizza> PizzasOfTheWeek { get; set; }
    }
}
