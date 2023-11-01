using AspFirstTask.Entities;
using System.Collections.Generic;

namespace AspFirstTask.Models
{
    public class AllMealsViewModel
    {
        public List<Drink> drinks { get; set; }
        public List<FastFood> fastFoods { get; set; }
        public List<HotMeal> hotMeals { get; set; }
    }
}
