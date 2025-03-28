using System;
using FinanceApp.Models;

namespace FinanceApp.Data.Services;

public interface IExpensesService
{
    Task<IEnumerable<Expense>> GetAllAsync();
    Task AddAsync(Expense expense);
}
