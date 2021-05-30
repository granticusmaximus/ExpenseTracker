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
        [HttpGet]
        public async Task<List<Expense>> GetAllExpenses()
        {
            return await _dbcontext.Expenses.AsQueryable().ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<Expense> GetSingleExpense(int id)
        {
            return await _dbcontext.Expenses.FindAsync(id);
        }
        [HttpPost]
        public async Task CreateExpense([FromBody] Expense expense)
        {
            if (ModelState.IsValid)
                await _dbcontext.AddAsync(expense);
            await _dbcontext.SaveChangesAsync();
        }
        [HttpPut]
        public void UpdateExpense([FromBody] Expense expense)
        {
            if (ModelState.IsValid)
                _dbcontext.Update(expense);
            _dbcontext.SaveChanges();
        }
        [HttpDelete("delete/{id}")]
        public void DeleteExpense(int id)
        {
            var entity = _dbcontext.Expenses.Find(id);
            _dbcontext.Expenses.Remove(entity);
            _dbcontext.SaveChanges();
        }
        #endregion

        #region Income Methods
        [HttpGet]
        public async Task<List<Income>> GetAllIncomes()
        {
            return await _dbcontext.Income.AsQueryable().ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<Income> GetSingleIncome(int id)
        {
            return await _dbcontext.Income.FindAsync(id);
        }
        [HttpPost]
        public async Task CreateIncome([FromBody] Income income)
        {
            if (ModelState.IsValid)
                await _dbcontext.AddAsync(income);
            await _dbcontext.SaveChangesAsync();
        }
        [HttpPut]
        public void UpdateIncome([FromBody] Income income)
        {
            if (ModelState.IsValid)
                _dbcontext.Update(income);
            _dbcontext.SaveChanges();
        }
        [HttpDelete("delete/{id}")]
        public void DeleteIncome(int id)
        {
            var entity = _dbcontext.Income.Find(id);
            _dbcontext.Income.Remove(entity);
            _dbcontext.SaveChanges();
        }
        #endregion
    }
}