using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cape_Senior_Center_Inventory_System.DTOs
{
    public class RecipeModel
    {
        public string RecipeName { get; set; }
        public List<string> Ingredients { get; set; }
    }
}
