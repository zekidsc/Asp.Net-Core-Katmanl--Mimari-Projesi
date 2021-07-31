﻿using Business.Abstract;
using DataAccess.Abstract;
using Microsoft.AspNetCore.Mvc;
using MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWebUI.Controllers
{
    public class CategoryController:Controller
    {
        private ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        //public IActionResult Index()
        //{
        //    var model = new CategoryListViewModel
        //    {
        //        Categories = _categoryService.GetAll()
        //    };

        //    return View(model);
        //}
    }
}
