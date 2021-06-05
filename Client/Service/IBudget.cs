using ExpenseTracker.Shared.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpenseTracker.Client.Service
{
    public interface IBudget
    {
        #region Income CRUD
        Task<List<Income>> LoadAllIncomeAsync();
        Task<Income> AddIncome();
        Task<Income> UpdateIncome();
        Task<Income> DeleteIncome();
        Task<Income> SumOfIncome();
        #endregion


        #region Expense CRUD
        Task<List<Expense>> LoadAllExpensesAsync();
        Task<Expense> AddExpense();
        Task<Expense> UpdateExpense();
        Task<Expense> DeleteExpense();
        Task<Expense> SumOfExpense();
        #endregion

        /* AmountLeft{SumOfIncome - SumOfExpense}*/
    }
}
