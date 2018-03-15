using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppBusinessProject;
using AppModelProject;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    public class ExpenseController : Controller
    {
        private readonly AppDbContext _appDbContext;
        private readonly IExpenseRepository _expenseRepository;

        public ExpenseController(AppDbContext appDbContext,  IExpenseRepository expenseRepository)
        {
            _appDbContext = appDbContext;
            _expenseRepository = expenseRepository;
        }

        public ViewResult List()
        {
            return View(_expenseRepository.GetExpense());
        }
    }
}
