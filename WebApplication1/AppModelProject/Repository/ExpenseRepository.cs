using AppModelProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppModelProject.Repository
{
    public class ExpenseRepository : IExpenseRepository
    {
        private readonly AppDbContext _appDbContext;

        public ExpenseRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void DeleteExpense(int expenseID)
        {
            var _expense = GetExpenseByID(expenseID);
            if (_expense != null)
                _appDbContext.Entry(_expense).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
        }



        public IEnumerable<Expense> GetExpense()
        {
            return _appDbContext.Expenses.ToList();
        }

        public Expense GetExpenseByID(int expenseId)
        {
            return _appDbContext.Expenses.FirstOrDefault(x => x.ExpenseId == expenseId);
        }

        public void InsertExpense(Expense expense)
        {
            _appDbContext.Entry(expense).State = Microsoft.EntityFrameworkCore.EntityState.Added;
        }

        public void Save()
        {
            _appDbContext.SaveChanges();
        }

        public void UpdateExpense(Expense expense)
        {
            _appDbContext.Entry(expense).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _appDbContext.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }

}
