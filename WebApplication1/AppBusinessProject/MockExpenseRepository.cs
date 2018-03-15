using System;
using System.Collections.Generic;
using System.Text;
using AppModelProject;

namespace AppBusinessProject
{
    public class MockExpenseRepository : IExpenseRepository
    {
        private readonly AppDbContext _appDbContext;

        public MockExpenseRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void DeleteExpense(int expenseID)
        {
            throw new NotImplementedException();
        }



        public IEnumerable<Expense> GetExpense()
        {
            return new List<Expense>()
            {
                new Expense{Amount=100.00M, Description = "Groceries", ExpenseDateTime = new DateTime(2018,02,01), ExpenseId=1, PaidTo="Woolworth"},
                new Expense{Amount=70.00M, Description = "Petrol", ExpenseDateTime = new DateTime(2018,02,02), ExpenseId=2, PaidTo="Coles Express"},
            };
        }

        public Expense GetExpenseByID(int expenseId)
        {
            throw new NotImplementedException();
        }

        public void InsertExpense(Expense expense)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void UpdateExpense(Expense expense)
        {
            throw new NotImplementedException();
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
