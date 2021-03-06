using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Recipes.Models;

namespace Recipes.Controllers
{
    public class RecipesController : Controller
    {
        [HttpGet("/recipes")]
        public IActionResult Index()
        {
            var db = new RecipeContext();
            return View(db.recipes.ToList());
        }

        [HttpGet("/recipes/new")]
        public IActionResult New()
        {
            return View(new RecipeContext().categories.ToList());
        }

        [HttpPost("/recipes")]
        public IActionResult Create(string recipeName, string recipeInstructions, int categoryId)
        {
            var db = new RecipeContext();
            var recipe = new Recipe {name = recipeName, instructions = recipeInstructions};
            db.recipes.Add(recipe);
            db.SaveChanges();
            if(categoryId > 0)
            {
              var join = new Join {recipe_id = recipe.id, category_id = categoryId};
              db.join.Add(join);
              db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpPost("/recipes/alphabet-asc")]
        public IActionResult SortAsc()
        {
          var db = new RecipeContext();
          return View("Index", db.recipes.OrderBy(j => j.name).ToList());
        }

        [HttpGet("/recipes/{id}")]
        public IActionResult Show(int id)
        {
            var db = new RecipeContext();
            return View(db.recipes.Find(id));
        }

        [HttpPost("/recipes/{id}/delete")]
        public IActionResult DeleteRecipe(int id)
        {
            var db = new RecipeContext();
            var recipe = db.recipes.Find(id);
            db.recipes.Remove(recipe);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet("/recipes/{id}/edit")]
        public IActionResult Edit(int id)
        {
            var db = new RecipeContext();
            var recipe = db.recipes.Find(id);
            return View(recipe);
        }

        [HttpPost("/recipes/{id}")]
        public IActionResult Update(int id, string recipeName, string recipeInstructions, int categoryId)
        {
            var db = new RecipeContext();
            var recipe = db.recipes.Find(id);
            if (recipeName != null)
            {
              recipe.name = recipeName;
            }
            if (recipeInstructions != null)
            {
              recipe.instructions = recipeInstructions;
            }
            db.SaveChanges();
            return RedirectToAction("Show", new {id = id});
        }

        [HttpPost("/recipes/{id}/add")]
        public IActionResult AddCategory(int id, int categoryId)
        {
            var db = new RecipeContext();
            var recipe = db.recipes.Find(id);
            if (categoryId > 0)
            {
              var join = new Join {recipe_id = recipe.id, category_id = categoryId};
              db.join.Add(join);
            }
            db.SaveChanges();
            return RedirectToAction("Show", new {id = id});
        }

        [HttpPost("/recipes/{id}/delete-category")]
        public IActionResult DeleteCategory(int id, int categoryId)
        {
            var db = new RecipeContext();
            var recipe = db.recipes.Find(id);
            if (categoryId > 0)
            {
              Join thisEntry = db.join.Where(j => j.recipe_id == id && j.category_id == categoryId).FirstOrDefault();
              db.join.Remove(thisEntry);
            }
            db.SaveChanges();
            return RedirectToAction("Show", new {id = id});
        }

    }
}
