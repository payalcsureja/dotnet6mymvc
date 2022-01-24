using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using APP.Data;
using APP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace APP.Controllers
{
    [Route("[controller]")]
    public class CategoryController : Controller
    {
        private readonly ILogger<CategoryController> _logger;
        private readonly ApplicationDbContext _db;

        public CategoryController(ILogger<CategoryController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }
         
        [HttpGet]
        public IActionResult Index()
        {
            IEnumerable<Category> objCategoryList = _db.Categories.ToList();
            return View(objCategoryList);
        }

        [HttpGet("create")]       
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost("create")]  
        [ValidateAntiForgeryToken]     
        public IActionResult Create(Category obj)
        {

            if(obj.Name == obj.DisplayOrder.ToString()){
                ModelState.AddModelError("CustomError", "Name and display order should not be same.");
            }

            if(ModelState.IsValid){
                _db.Categories.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Created successfully";
                return RedirectToAction("Index");
            }
            return View(obj);
            
        }

        [HttpGet("edit")]       
        public IActionResult Edit(int? id)
        {
            if(id==null || id ==0){
                return NotFound();
            }
            var CategoryFromDb = _db.Categories.Find(id);
            if(CategoryFromDb == null){
                return NotFound();
            }
            return View(CategoryFromDb);
        }

        [HttpPost("edit")]  
        [ValidateAntiForgeryToken]     
        public IActionResult Edit(Category obj)
        {

            if(obj.Name == obj.DisplayOrder.ToString()){
                ModelState.AddModelError("CustomError", "Name and display order should not be same.");
            }

            if(ModelState.IsValid){
                _db.Categories.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "Updated successfully";
                return RedirectToAction("Index");
            }
            return View(obj);
            
        }

        [HttpGet("delete")]       
        public IActionResult Delete(int? id)
        {
            if(id==null || id ==0){
                return NotFound();
            }
            var CategoryFromDb = _db.Categories.Find(id);
            if(CategoryFromDb == null){
                return NotFound();
            }
            return View(CategoryFromDb);
        }

        [HttpPost("delete"), ActionName("Delete")]  
        [ValidateAntiForgeryToken]     
        public IActionResult DeletePost(int? id)
        {
 
            var obj = _db.Categories.Find(id);
            if(obj==null){
                return NotFound();
            }            
             
            _db.Categories.Remove(obj);
            _db.SaveChanges();
            TempData["success"] = "Deleted successfully";
            return RedirectToAction("Index");
            
            
        }
        
    }
}