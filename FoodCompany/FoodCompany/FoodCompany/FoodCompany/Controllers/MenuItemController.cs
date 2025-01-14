using FoodCompany.Models;
using FoodCompany.Repository;
using Microsoft.AspNetCore.Mvc;

namespace FoodCompany.Controllers
{
    public class MenuItemController : Controller
    {

        private readonly IUnitOfWork _unitOfWork;

        public MenuItemController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
             List<MenuItem> menuItemList = _unitOfWork.MenuItem.GetAllExpression().ToList();
            return View(menuItemList);
        }

        // GET: CategoryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MenuItem menuItem)
        {
            try
            {
                if (menuItem == null)
                {
                    return RedirectToAction(nameof(Index));
                }

                if (ModelState.IsValid)
                {
                    _unitOfWork.MenuItem.Add(menuItem);
                    _unitOfWork.Save();
                    TempData["Success"] = "Item created successfully";
                    return RedirectToAction("Index");
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
