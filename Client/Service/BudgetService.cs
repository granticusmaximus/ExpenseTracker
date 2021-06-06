using ExpenseTracker.Shared.Models;
using System;
using System.Collections.Generic;
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
        public async Task<List<Expense>> LoadAllExpensesAsync()
        {
            return await _http.GetFromJsonAsync<List<Expense>>("api/Expense/GetExpenses");
        }

        public Task<Expense> AddExpense()
        {
            throw new NotImplementedException();
        }

        public Task<Expense> UpdateExpense(int ID)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteExpense(int ID)
        {
            await _http.DeleteAsync($"api/Expense/deleteexpense/{ID}");
        }

        public Task<Expense> SumOfExpense()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Income Region
        public async Task<List<Income>> LoadAllIncomeAsync()
        {
            return await _http.GetFromJsonAsync<List<Income>>("api/Expense/GetIncomes");
        }

        public async Task<Income> AddIncome(int ID)
        {
            await _http.PostAsJsonAsync($"/api/Handheld/Create?id={ID}");
        }

        public Task<Income> UpdateIncome(int ID)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteIncome(int ID)
        {
            await _http.DeleteAsync($"api/Expense/deleteincome?id={ID}");
        }

        public Task<Income> SumOfIncome()
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}
