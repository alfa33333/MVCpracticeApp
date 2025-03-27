using System;
using FinanceApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FinanceApp.Data;

public class FinanceAppContext : DbContext
{
    public FinanceAppContext(DbContextOptions<FinanceAppContext> options)
        : base(options) { }

    DbSet<Expense> Expenses { get; set; }
}
