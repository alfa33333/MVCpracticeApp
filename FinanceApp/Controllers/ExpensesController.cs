using FinanceApp.Data;
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
    }
}
