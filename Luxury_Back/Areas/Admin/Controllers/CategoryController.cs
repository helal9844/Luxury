﻿using FluentValidation.Results;
using Luxury_Back.Areas.Admin.Validations;
using Luxury_Back.DB;
using Luxury_Back.Helpers;
using Luxury_Back.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Localization;
using System;
using System.Data;
using System.Diagnostics;

namespace Luxury_Back.Controllers.Admin
{
    [Authorize(Roles = "admin")]
    [Area("admin")]
    public class CategoryController : Controller
    {
        private LuxuryDb luxuryDb;
        private readonly IStringLocalizer<CategoryController> localizer;
        const string viewPath= "Areas/Admin/Views/Category/";
        public CategoryController(LuxuryDb luxuryDb, IStringLocalizer<CategoryController> _localizer)
        {
            this.luxuryDb = luxuryDb;
            this.localizer = _localizer;
        }
        public IActionResult Index()
        {
            //return luxuryDb.categories.Include(c => c.translations).Include(c=>c.parent).ThenInclude(p=>p.translations).Where(c => c.Id == 2).First().parent.name;
            var categories = luxuryDb.categories.Include(c=>c.parent).ToList();
            return View(categories);
        }
        [HttpGet]
        #region Create
        public IActionResult Create(Category? category)
        {
            List<Category> categories = luxuryDb.categories.Where(c=>c.CategoryId == null).ToList();
            ViewBag.categories = categories;
            return View($"{viewPath}Create_Edit.cshtml",category);
        }
        [HttpPost]
        public IActionResult _Create(Category category,IFormFile img_category)
        {
            CategoryCreateValidation validator = new CategoryCreateValidation(localizer);

            ValidationResult results = validator.Validate(category);
            if (!results.IsValid)
            {
                foreach (var error in results.Errors)
                {
                    TempData[error.PropertyName] = error.ErrorMessage;
                }
                return Create(category);
            }
           
            using (IDbContextTransaction transaction = luxuryDb.Database.BeginTransaction())
            {
                try
                {
                    Category? _category = luxuryDb.categories
                        .Where(_ => _.name_ar == category.name_ar || _.name_en == category.name_en)
                        .FirstOrDefault();

                    if (_category != null)
                    {
                        TempData["error_msg"] = "This Category exsited!";
                        return Create(category);
                    }
                    
                    category.img_category = @"DefaultImage.png";
                    if (category.CategoryId !=null && img_category != null)
                    {
                        string? img = Helper.uploadeFile(img_category, "category");
                        /*string uniqueImge = DateTime.Now.ToString("yyyyyMMddHHmmss") + "." + img_category.FileName.Split(".")[1];
                        if (!System.IO.Directory.Exists(@".\wwwroot\images\category"))
                        {
                            System.IO.Directory.CreateDirectory(@".\wwwroot\images\category");
                        }
                        using (var obj = new FileStream(@".\wwwroot\images\category\" + uniqueImge, FileMode.Create))
                        {
                            img_category.CopyTo(obj);
                        }*/
                        category.img_category = img;
                    }
                    

                    luxuryDb.categories.Add(category);
                    luxuryDb.SaveChanges();
                    transaction.Commit();
                }
                catch(Exception ex)
                {
                    transaction.Rollback();
                    TempData["error_msg"] = ex.Message;
                    return Create(category);
                }
            }
           
            return RedirectToAction("Index");
        }
        //[HttpPost]
        //public IActionResult CreateCategory()
        //{
        //    var category = new Category();
        //    //List<CategoryTranslation> translations = new List<CategoryTranslation>();
        //    foreach(var item in Request.Form)
        //    {
        //        if(item.Key == "IsActive")
        //        {
        //            category.IsActive = bool.Parse(item.Value);
        //        }
        //        if (item.Key == "CategoryId")
        //        {
        //            category.CategoryId = string.IsNullOrWhiteSpace(item.Value)? null:int.Parse(item.Value);
        //        }
        //        if (item.Key.Contains("name-"))
        //        {
        //            var locale = item.Key.Split("-")[1];
        //            var name = item.Value;
        //            /*translations.Add(new CategoryTranslation
        //            {
        //                locale = locale,
        //                Name = name
        //            });*/
        //        }
        //    }
        //    //category.translations = translations;
        //    luxuryDb.categories.Add(category);
        //    luxuryDb.SaveChanges();
        //    return RedirectToAction("index");
        //}
        #endregion
        public IActionResult Activation(int? id)
        {
            var category = luxuryDb.categories.Include(i => i.iBookings).Include(c => c.childs).ThenInclude(t=>t.iBookings).Where(i => i.Id == id).First();
            if (category == null)
            {
                TempData["error_msg"] = "Category is Not Allow";
            }
            else
            {
                using (IDbContextTransaction transaction = luxuryDb.Database.BeginTransaction())
                {
                    try
                    {
                        category.IsActive = category.IsActive ? false : true;
                        if (category.childs.Count() != 0 && category.childs.Count != null)
                        {
                            foreach (var item in category.childs)
                            {
                                item.IsActive = category.IsActive;
                              
                                foreach (var iBooking in item.iBookings)
                                {
                                    if (item.Id == iBooking.Category_Id)
                                    {
                                        iBooking.IsActive = category.IsActive;
                                    }
                                }
                            }
                        }
                        //
                        if (category.childs.Count() == 0)
                        {
                            category.IsActive = category.IsActive?true:false;    
                            foreach (var item in category.iBookings)
                            {
                                if (category.Id == item.Category_Id)
                                {
                                    item.IsActive = category.IsActive;
                                }
                            }
                        }
                        //
                        luxuryDb.SaveChanges();
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                    }
                }
                //var cat_book = luxuryDb.categories.Include(i => i.iBookings).Where(w => w.Id == id).First();
                //cat_book.IsActive = category.IsActive?false : true;
                //if (cat_book.childs.Count() == 0)
                //{
                //    foreach (var item in cat_book.iBookings)
                //    {
                //        if (cat_book.Id == item.Category_Id)
                //        {
                //            item.IsActive = cat_book.IsActive;
                //        }
                //    }
                //}
                //luxuryDb.SaveChanges();
               
            }
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var category = luxuryDb.categories.Where(i => i.Id == id).First();
            if (category == null)
            {
                TempData["error_msg"] = "Category is Not Allow";
                return RedirectToAction("Index");
            }
            int categoryChildCount = luxuryDb.categories.Count(c => c.CategoryId == id);
            int categoryIbookingCount = luxuryDb.iBookings.Count(c => c.Category_Id == id);
            int categoryBrandsCount = luxuryDb.brands.Count(c => c.CategoryId == id);
            if (categoryChildCount != 0)
            {
                TempData["error_msg"] = $"Sorry Can't Remove This Category Because it has {categoryChildCount} child Categories";
            }
            else if (categoryBrandsCount != 0)
            {
                TempData["error_msg"] = $"Sorry Can't Remove This Category Because it has {categoryBrandsCount} brands";
            }
            else if (categoryIbookingCount != 0)
            {
                TempData["error_msg"] = $"Sorry Can't Remove This Category Because it has {categoryIbookingCount} bookings";
            }
            else
            {
                using (IDbContextTransaction transaction = luxuryDb.Database.BeginTransaction())
                {
                    try
                    {
                        luxuryDb.categories.Remove(category);
                        luxuryDb.SaveChanges();
                        transaction.Commit();
                        TempData["success_msg"] = "Category Deleted Successfully!";
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        TempData["error_msg"] = "Sorry Can't Remove This Category";
                    }
                }
            }
            return RedirectToAction("Index");
        }
        #region Edit
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Category category = luxuryDb.categories.Where(i=>i.Id ==id).First();
            List<Category> categories = luxuryDb.categories.Where(c => c.CategoryId == null).ToList();
            ViewBag.categories = categories;
            return View(category);
        }
        
        [HttpPost]
        public IActionResult Edit(Category category, IFormFile img_category)
        {
            CategoryCreateValidation validator = new CategoryCreateValidation(localizer);

            ValidationResult results = validator.Validate(category);
            if (!results.IsValid)
            {
                foreach (var error in results.Errors)
                {
                    TempData[error.PropertyName] = error.ErrorMessage;
                }
                return Edit(category.Id);
            }
            using (IDbContextTransaction transaction = luxuryDb.Database.BeginTransaction())
            {
                try
                {
                    var _category = luxuryDb.categories
                        .Where(_ => _.name_ar == category.name_ar || _.name_en == category.name_en)
                        .Where(w=>w.Id!=category.Id)
                        .FirstOrDefault();
                    if (_category == null)
                    {
                        if (category.CategoryId != null && img_category != null)
                        {
                            category.img_category = @"DefaultImage.png";
                            if (category.CategoryId != null) {
                                string? img = Helper.uploadeFile(img_category, "category");
                                category.img_category = img;
                            }
                        }

                        luxuryDb.categories.Update(category);
                        luxuryDb.SaveChanges();
                        transaction.Commit();
                    }         
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    TempData["error_msg"] = ex.Message;
                }
            }
            return RedirectToAction("Index");

        }
        #endregion
        public int GetNextId()
        {
            return luxuryDb.categories.Max(a => a.Id) + 1;
        }
    }
   
}