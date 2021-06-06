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
        Task<Income> UpdateIncome(int ID);
        Task<Income> DeleteIncome(int ID);
        Task<Income> SumOfIncome();
        #endregion


        #region Expense CRUD
        Task<List<Expense>> LoadAllExpensesAsync();
        Task<Expense> AddExpense();
        Task<Expense> UpdateExpense(int ID);
        Task DeleteExpense(int ID);
        Task<Expense> SumOfExpense();
        #endregion

        /* AmountLeft{SumOfIncome - SumOfExpense}*/
    }
}
