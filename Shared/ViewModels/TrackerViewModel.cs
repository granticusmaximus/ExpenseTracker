using ExpenseTracker.Shared.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Shared.ViewModels
{
    public class TrackerViewModel
    {
        public List<Income> IncomeList { get; set; }
        public Income SingleIncomeItem { get; set; }
        public List<Expense> ExpenseList { get; set; }
        public Income SingleExpenseItem { get; set; }
    }
}
