using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppBusinessProject.Interfaces;
using AppModelProject.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerLogic _customerLogic;

        public CustomerController(ICustomerLogic customerLogic)
        {
            _customerLogic = customerLogic;
        }

        public ViewResult List()
        {
            return View(_customerLogic.GetCustomers());
        }

        public ViewResult ListOfExpensesByCustomerId(int customerId)
        {
            return View(_customerLogic.GetExpenseByCustomerId(customerId));
        }
    }
}