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
        public IActionResult Index()
        {
            List<Drink> drinks = new List<Drink>() {
                new Drink
                {
                    drinkName="Coffee",
                    price=2,
                    calorie=300
                },
                new Drink
                {
                    drinkName="Chocolate milk",
                    price=4.5,
                    calorie=200
                },
                new Drink
                {
                    drinkName="Hot chocolate",
                    price=3.5,
                    calorie=100
                },
                new Drink
                {
                    drinkName="Milkshake",
                    price=5,
                    calorie=200
                },
                new Drink
                {
                    drinkName="Orange juice",
                    price=3,
                    calorie=200
                },
            };

            List<HotMeal> hotMeals = new List<HotMeal>()
            {
                new HotMeal
                {
                     hotMealName="Lyuyla Kebab",
                    price=35,
                    calorie=200
                },

                new HotMeal
                {
                    hotMealName="Shah Pilaf",
                    price=20,
                    calorie=200
                },

                new HotMeal
                {
                    hotMealName="Baliq Kebab",
                    price=30,
                    calorie=200
                },

                new HotMeal
                {
                    hotMealName="Yarpaq Dolmasi",
                    price=15,
                    calorie=200
                },
            };

            List<FastFood> fastFoods = new List<FastFood>()
            {
                new FastFood
                {
                     fastFoodName="Pizza",
                    price=13,
                    calorie=200

                },

                new FastFood
                {
                    fastFoodName="Fries Chicken",
                    price=11,
                    calorie=200

                },

                new FastFood
                {
                    fastFoodName="Noodles",
                    price=9,
                    calorie=200

                },

                new FastFood
                {
                    fastFoodName="Cheeseburger",
                    price=10,
                    calorie=200

                }
            };

            AllMealsViewModel allMeals = new AllMealsViewModel();
            allMeals.drinks = drinks;
            allMeals.hotMeals = hotMeals;
            allMeals.fastFoods = fastFoods;
            
            return View(allMeals);
        }

        //public IActionResult Drinks()
        //{

        //}

        //public IActionResult HotMeals()
        //{

        //}

        //public IActionResult FastFoods()
        //{

        //}
    }
}
