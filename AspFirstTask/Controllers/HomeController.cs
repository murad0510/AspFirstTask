using AspFirstTask.Entities;
using AspFirstTask.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AspFirstTask.Controllers
{
    public class HomeController : Controller
    {
            List<Drink> drinks = new List<Drink>() {
                new Drink
                {
                    Id = 1,
                    drinkName="Coffee",
                    price=2,
                    calorie=300
                },
                new Drink
                {
                    Id = 2,
                    drinkName="Chocolate milk",
                    price=4.5,
                    calorie=200
                },
                new Drink
                {
                    Id = 3,
                    drinkName="Hot chocolate",
                    price=3.5,
                    calorie=100
                },
                new Drink
                {
                        Id = 4,
                    drinkName="Milkshake",
                    price=5,
                    calorie=200
                },
                new Drink
                {
                    Id = 5,
                    drinkName="Orange juice",
                    price=3,
                    calorie=200
                },
            };

            List<HotMeal> hotMeals = new List<HotMeal>()
            {
                new HotMeal
                {
                    Id = 1,
                     hotMealName="Lyuyla Kebab",
                    price=35,
                    calorie=200
                },

                new HotMeal
                {
                        Id = 2,
                    hotMealName="Shah Pilaf",
                    price=20,
                    calorie=200
                },

                new HotMeal
                {
                    Id = 3,
                    hotMealName="Baliq Kebab",
                    price=30,
                    calorie=200
                },

                new HotMeal
                {
                    Id = 4,
                    hotMealName="Yarpaq Dolmasi",
                    price=15,
                    calorie=200
                },
            };

            List<FastFood> fastFoods = new List<FastFood>()
            {
                new FastFood
                {
                    Id = 1,
                     fastFoodName="Pizza",
                    price=13,
                    calorie=200

                },

                new FastFood
                {
                    Id = 2,
                    fastFoodName="Fries Chicken",
                    price=11,
                    calorie=200

                },

                new FastFood
                {
                    Id = 3,
                    fastFoodName="Noodles",
                    price=9,
                    calorie=200

                },

                new FastFood
                {
                    Id= 4,
                    fastFoodName="Cheeseburger",
                    price=10,
                    calorie=200

                }
            };
        public IActionResult Index()
        {
            AllMealsViewModel allMeals = new AllMealsViewModel();
            allMeals.drinks = drinks;
            allMeals.hotMeals = hotMeals;
            allMeals.fastFoods = fastFoods;
            return View(allMeals);
        }

        public IActionResult Drinks()
        {
            DrinkViewModel drinkViewModel = new DrinkViewModel();
            drinkViewModel.drinks=drinks;
            return View(drinkViewModel);
        }

        public IActionResult HotMeals()
        {
            HotMealViewModel hotMealViewModel = new HotMealViewModel();
            hotMealViewModel.hotMeals = hotMeals;
            return View(hotMealViewModel);
        }

        public IActionResult FastFoods()
        {
            FastFoodViewModel fastFoodViewModel = new FastFoodViewModel();
            fastFoodViewModel.fastFoods = fastFoods;
            return View(fastFoodViewModel);
        }
    }
}
