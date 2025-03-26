using System;
using System.ComponentModel.DataAnnotations;

namespace FinanceApp.Models;

public class Expense
{
    public int Id { get; set; }

    [Required]
    public string Description { get; set; } = string.Empty;

    [Required]
    [Range(0.01, double.MaxValue, ErrorMessage = "Amount must be greater than 0.01")]
    public double Amount { get; set; }

    [Required]
    public string Category { get; set; } = string.Empty;
    public DateTime Date { get; set; } = DateTime.Now;
}
