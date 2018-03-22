using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppBusinessProject;
using AppModelProject;
using AppModelProject.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    public class ExpenseController : Controller
    {
        private readonly IExpenseRepository _expenseRepository;

        public ExpenseController(IExpenseRepository expenseRepository)
        {
            _expenseRepository = expenseRepository;
        }

        public ViewResult List()
        {
            return View(_expenseRepository.GetExpense());
        }

        public ViewResult ListByCustomer(int customerId)
        {
            return View(_expenseRepository.GetExpense().Where(x => x.CustomerId == customerId));
        }
    }
}
