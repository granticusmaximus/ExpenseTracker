﻿using ExpenseTracker.Server.Data;
using ExpenseTracker.Shared.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpenseTracker.Server.Controllers
{
    [Route("api/[controller]")]
    public class ExpenseController : Controller
    {
        private readonly ApplicationDbContext _dbcontext;

        public ExpenseController(ApplicationDbContext dbcontext)
        {
            this._dbcontext = dbcontext;
        }

        #region Expenses Methods
        [HttpGet("GetExpenses")]
        public async Task<List<Expense>> GetAllExpenses()
        {
            return await _dbcontext.Expenses.AsQueryable().ToListAsync();
        }

        [HttpGet("GetSingleExpense/{id}")]
        public async Task<Expense> GetSingleExpense(int id)
        {
            return await _dbcontext.Expenses.FindAsync(id);
        }
        [HttpPost("CreateExpense")]
        public async Task CreateExpense([FromBody] Expense expense)
        {
            if (ModelState.IsValid)
                await _dbcontext.AddAsync(expense);
            await _dbcontext.SaveChangesAsync();
        }
        [HttpPut("UpdateExpense/{id}")]
        public void UpdateExpense([FromBody] Expense expense)
        {
            if (ModelState.IsValid)
                _dbcontext.Update(expense);
            _dbcontext.SaveChanges();
        }
        [HttpDelete("deleteexpense/{id}")]
        public void DeleteExpense(int id)
        {
            var entity = _dbcontext.Expenses.Find(id);
            _dbcontext.Expenses.Remove(entity);
            _dbcontext.SaveChanges();
        }

        [HttpGet("GetExpenseSum")]
        public double ExpenseSum(Int32 ID)
        {
            List<string> sumList = new List<string>();
            sumList = (from c in _dbcontext.Expenses where c.ID == ID select c.Amount.ToString()).ToList();

            double Total = 0;

            if (sumList != null)
            {
                for (int i = 0; i < sumList.Count; i++)
                {
                    Total += Convert.ToDouble(sumList[i]);
                }
            }

            return Total;
        }

        #endregion

        #region Income Methods
        [HttpGet("GetIncomes")]
        public async Task<List<Income>> GetAllIncomes()
        {
            return await _dbcontext.Income.AsQueryable().ToListAsync();
        }

        [HttpGet("GetSingleIncome/{id}")]
        public async Task<Income> GetSingleIncome(int id)
        {
            return await _dbcontext.Income.FindAsync(id);
        }
        [HttpPost("Createincome")]
        public async Task CreateIncome([FromBody] Income income)
        {
            if (ModelState.IsValid)
                await _dbcontext.AddAsync(income);
            await _dbcontext.SaveChangesAsync();
        }
        [HttpPut("UpdateIncome/{id}")]
        public void UpdateIncome([FromBody] Income income)
        {
            if (ModelState.IsValid)
                _dbcontext.Update(income);
            _dbcontext.SaveChanges();
        }

        [HttpGet("GetIncomeSum")]
        public double IncomeSum(int ID)
        {
            List<string> sumList = new List<string>();
            sumList = (from c in _dbcontext.Income where c.ID == ID select c.Amount.ToString()).ToList();

            double Total = 0;

            if (sumList != null)
            {
                for (int i = 0; i < sumList.Count; i++)
                {
                    Total += Convert.ToDouble(sumList[i]);
                }
            }

            return Total;
        }

        [HttpDelete("deleteincome")]
        public void DeleteIncome([FromQuery] int id = default)
        {
            var entity = _dbcontext.Income.Find(id);
            _dbcontext.Income.Remove(entity);
            _dbcontext.SaveChanges();
        }
        #endregion
    }
}
