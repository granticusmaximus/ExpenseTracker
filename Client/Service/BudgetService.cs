using ExpenseTracker.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ExpenseTracker.Client.Service
{
    public class BudgetService : IBudget
    {
        private readonly HttpClient _http;
        public BudgetService(HttpClient http)
        {
            _http = http;
        }

        #region Expense Region
        public Task<List<Expense>> LoadAllExpensesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Expense> AddExpense()
        {
            throw new NotImplementedException();
        }

        public Task<Expense> UpdateExpense()
        {
            throw new NotImplementedException();
        }

        public Task<Expense> DeleteExpense()
        {
            throw new NotImplementedException();
        }

        public Task<Expense> SumOfExpense()
        {
            throw new NotImplementedException();
        }
        #endregion

        public async Task<List<Income>> LoadAllIncomeAsync()
        {
            return await _http.GetFromJsonAsync<Income>("api/SiteSample/GetTransect");
        }

        public Task<Income> AddIncome()
        {
            throw new NotImplementedException();
        }

        public Task<Income> UpdateIncome()
        {
            throw new NotImplementedException();
        }

        public Task<Income> DeleteIncome()
        {
            throw new NotImplementedException();
        }

        public Task<Income> SumOfIncome()
        {
            throw new NotImplementedException();
        }
        
    }
}
