using System;
using FinanceApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FinanceApp.Data.Services;

public class ExpensesService : IExpensesService
{
    private readonly FinanceAppContext _context;

    public ExpensesService(FinanceAppContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Expense expense)
    {
        _context.Expenses.Add(expense);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<Expense>> GetAllAsync()
    {
        var expenses = await _context.Expenses.ToListAsync();
        return expenses;
    }
}
