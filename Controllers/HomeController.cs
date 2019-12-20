using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChefsNDishes.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChefsNDishes.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
        public HomeController(MyContext context)
        {
            dbContext = context;
        }
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Allchefs = dbContext.Chefs.Include(c => c.AddedDishes).OrderByDescending(c => c.ChefId);
            return View();
        }

        [HttpGet("new")]
        public IActionResult AddChef()
        {
            // System.Console.WriteLine("Add Chef page");
            return View();
        }

        [HttpPost("addChef")]
        public IActionResult AddChef(Chef newChef)
        {
            if(ModelState.IsValid)
            {
                DateTime Current = newChef.UpdatedAt;
                DateTime dob = newChef.DateOfBirth;
                int age = Current.Year - dob.Year;
                System.Console.WriteLine("modelstate valid"); 

                if (dob > Current)
                {
                    ModelState.AddModelError( "DateOfBirth", "Birthdate must be less than current date");
                    System.Console.WriteLine("date validation is working");
                    return View("AddChef");
                }
                if (age < 18)
                {
                    ModelState.AddModelError("DateOfBirth", "You must be 18 years old");
                    return View("AddChef");
                }

                newChef.Age = age;
                dbContext.Chefs.Add(newChef);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("AddChef");
        }

        [HttpGet("dishes")]
        public IActionResult Dishes()
        {
            ViewBag.AllDishes = dbContext.Dishes.Include(d => d.Chef).OrderByDescending(c => c.DishId);
            return View();
        }

        [HttpGet("dishes/new")]
        public IActionResult AddDish()
        {
            ViewBag.AllChefs = dbContext.Chefs;
            return View();
        }

        [HttpPost("dishes/addDish")]
        public IActionResult AddDish(Dish newDish)
        {
            if (ModelState.IsValid)
            {
                dbContext.Dishes.Add(newDish);
                dbContext.SaveChanges();
                return RedirectToAction("Dishes");
            }
            ViewBag.AllChefs = dbContext.Chefs;
            return View("AddDish");
        }

        // [HttpGet("dishes/delete")]
        // public IActionResult Delete(Dish DeleteId)
        // {
        //     dbContext.Dishes.Remove(DeleteId);
        //     dbContext.SaveChanges();
        //     return RedirectToAction("Dishes");
        // }

        [HttpGet("dishes/delete")]
        public IActionResult Delete(int dishId)
        {
            Dish delete = dbContext.Dishes.FirstOrDefault(d => d.DishId == dishId);

            if(delete == null)
                return RedirectToAction("Dishes");
            dbContext.Dishes.Remove(delete);
            dbContext.SaveChanges();
            System.Console.WriteLine("delete is working");
            return RedirectToAction("Dishes");
        }

        [HttpGet("dishes/deleteChef")]
        public IActionResult DeleteChef(int chefId)
        {
            Chef delete = dbContext.Chefs.FirstOrDefault(d => d.ChefId == chefId);

            if(delete == null)
                return RedirectToAction("index");
            dbContext.Chefs.Remove(delete);
            dbContext.SaveChanges();
            System.Console.WriteLine("delete is working");
            return RedirectToAction("index");
        }

        [HttpGet("dishes/edit{dishId}")]
        public IActionResult EditDish(int dishId)
        {
            Dish dish = dbContext.Dishes.FirstOrDefault(d => d.DishId == dishId);
            ViewBag.AllChefs = dbContext.Chefs;
            ViewBag.AllDishes = dbContext.Dishes.Include(d => d.Chef);
            return View(dish);
        }

        [HttpPost("dishes/update{dishId}")]
        public IActionResult Update(Dish dish, int dishId)
        {
            Dish toUpdate = dbContext.Dishes.FirstOrDefault(d => d.DishId == dishId);

            if (ModelState.IsValid)
            {
                toUpdate.Chef = dish.Chef;
                toUpdate.Name = dish.Name;
                toUpdate.Calories = dish.Calories;
                toUpdate.Tastiness = dish.Tastiness;
                toUpdate.Description = dish.Description;
                dbContext.SaveChanges();
                return RedirectToAction("dishes");
            }
            return View("EditDish");
        }
        [HttpGet("{dishId}")]
        public IActionResult Details(int dishId)
        {
            System.Console.WriteLine("show page");
            // Dish dish = dbContext.Dishes.FirstOrDefault(d => d.DishId == dishId);
            Dish dish = dbContext.Dishes.Where(d => d.DishId == dishId).Include(c=> c.Chef).FirstOrDefault();
            return View(dish);
        }
    }
}
