﻿using Luxury_Back.DB;
using Luxury_Back.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System.Diagnostics;

namespace Luxury_Back.Controllers.Admin
{
    public class CategoryController : Controller
    {
        const string ViewPath = "Views/Admin/Category/";
        private LuxuryDb luxuryDb;

        public CategoryController(LuxuryDb luxuryDb)
        {
            this.luxuryDb = luxuryDb;
        }

        public IActionResult Index()
        {
            //return luxuryDb.categories.Include(c => c.translations).Include(c=>c.parent).ThenInclude(p=>p.translations).Where(c => c.Id == 2).First().parent.name;
            var categories = luxuryDb.categories.Include(c => c.translations).Include(c=>c.parent).ThenInclude(p=>p.translations).ToList();
            return View($"{ViewPath}Index.cshtml", categories);
        }
        public IActionResult Delete(int id)
        {
            var category = luxuryDb.categories.Include(c=>c.childs).Where(i=>i.Id ==id).First();
            if (category == null)
            {
                TempData["error_msg"] = "Category is Not Allow";
            }
            else if (category.childs.Count() != 0 && category.childs.Count != null)
            {
                TempData["error_msg"] = "Sorry Can't Remove This Category";
            }
            else
            {
                using(IDbContextTransaction transaction = luxuryDb.Database.BeginTransaction()) {
                    try
                    {
                        luxuryDb.categories.Remove(category);
                        luxuryDb.SaveChanges();
                        transaction.Commit();
                        TempData["success_msg"] = "Category Deleted Successfully!";
                    }
                    catch(Exception ex)
                    {
                        transaction.Rollback();
                        TempData["error_msg"] = ex.Message;
                    }
                }
            }
            return RedirectToAction("Index");
        }

    }
}
