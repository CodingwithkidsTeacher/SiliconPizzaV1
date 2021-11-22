using System.Collections.Generic;

namespace SiliconPizza.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
