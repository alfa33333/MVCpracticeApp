using FinanceApp.Data;
using FinanceApp.Data.Services;
using FinanceApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinanceApp.Controllers
{
    public class ExpensesController : Controller
    {
        // GET: ExpensesController
        private readonly IExpensesService _expensesService;

        public ExpensesController(IExpensesService expensesService)
        {
            _expensesService = expensesService;
        }

        public async Task<ActionResult> Index()
        {
            var expenses = await _expensesService.GetAllAsync();

            return View(expenses);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(Expense expense)
        {
            if (ModelState.IsValid)
            {
                await _expensesService.AddAsync(expense);

                return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult GetChart()
        {
            var data = _expensesService.GetChartData();
            return Json(data);
        }
    }
}
