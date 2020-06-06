using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using LibraryManagment.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using LibraryManagment.Models;
using LibraryManagement.Framework;

namespace LibraryManagment.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BooksController : Controller
    {        
        private readonly IConfiguration _configaration;
        public BooksController(IConfiguration configuration)
        {
            _configaration = configuration;
        }
        public IActionResult Index()
        {
            var model =Startup.AutofacContainer.Resolve<BooksModel>();            
            return View(model);
        }
        
        public IActionResult AddBook()
        {
            var model = new CreateBookModel();
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddBook([
            Bind(nameof(CreateBookModel.Title),
            nameof(CreateBookModel.Author),
            nameof(CreateBookModel.Edition))] CreateBookModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    model.Create();
                    //var response = new ResponseModel("Book creation successful.", ResponseType.Success);
                    //HttpContext.Session.Set("Response", response);
                    model.Response = new ResponseModel("Book creation successful.", ResponseType.Success);
                    return RedirectToAction("Index");
                }
                catch(DuplicationException ex)
                {
                    model.Response = new ResponseModel(ex.Message, ResponseType.Failure);
                }
                catch (Exception ex)
                {
                    model.Response = new ResponseModel("Book creation failed.", ResponseType.Failure);
                }
            }
            return View(model);
        }
        public IActionResult EditBook(int id)
        {
            var model = new EditBookModel();
            model.Load(id);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditBook(
            [Bind(nameof(EditBookModel.Id),
            nameof(EditBookModel.Title),
            nameof(EditBookModel.Author),
            nameof(EditBookModel.Edition))] EditBookModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    model.Edit();
                    model.Response = new ResponseModel("Book creation successful.", ResponseType.Success);
                    return RedirectToAction("Index");
                }
                catch (DuplicationException ex)
                {
                    model.Response = new ResponseModel(ex.Message, ResponseType.Failure);
                    // error logger code
                }
                catch (Exception ex)
                {
                    model.Response = new ResponseModel("Book creation failued.", ResponseType.Failure);
                     // error logger code
                 }
             }
             return View(model);
         }
 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteBook(int id)
        {
            if (ModelState.IsValid)
            {
                var model = new BooksModel();
                try
                {
                    var title = model.Delete(id);
                    model.Response = new ResponseModel($"Book {title} successfully deleted.", ResponseType.Success);
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    model.Response = new ResponseModel("Book delete failued.", ResponseType.Failure);
                    // error logger code
                }
            }
            return RedirectToAction("index");
        }

        public IActionResult GetBooks()
        {
            var tableModel = new DataTableAjaxRequestModels(Request);
            using var model = Startup.AutofacContainer.Resolve<BooksModel>();
            var data = model.GetBooks(tableModel);
            return Json(data);
        }
    }
}