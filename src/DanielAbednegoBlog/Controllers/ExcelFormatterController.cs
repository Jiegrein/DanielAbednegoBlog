using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DanielAbednegoBlog.Controllers
{
    public class ExcelFormatterController : Controller
    {
        // GET: ExcelFormatterController
        public IActionResult Index()
        {
            return View();
        }

        // GET: ExcelFormatterController/Details/5
        public IActionResult Details(int id)
        {
            return View();
        }

        // GET: ExcelFormatterController/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ExcelFormatterController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ExcelFormatterController/Edit/5
        public IActionResult Edit(int id)
        {
            return View();
        }

        // POST: ExcelFormatterController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ExcelFormatterController/Delete/5
        public IActionResult Delete(int id)
        {
            return View();
        }

        // POST: ExcelFormatterController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
