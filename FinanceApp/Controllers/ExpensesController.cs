using FinanceApp.Data;
using FinanceApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinanceApp.Controllers
{
    public class ExpensesController : Controller
    {
        // GET: ExpensesController
        private readonly FinanceAppContext _context;

        public ExpensesController(FinanceAppContext context)
        {
            _context = context;
        }

        public ActionResult Index()
        {
            var expenses = _context.Expenses.ToList();

            return View(expenses);
        }

        [HttpPost]
        public IActionResult Create(Expense expense)
        {
            if (ModelState.IsValid)
            {
                _context.Expenses.Add(expense);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View();
        }
    }
}
