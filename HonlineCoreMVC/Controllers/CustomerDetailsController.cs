using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Bl;
using HonlineCoreMVC.Common.Utility;
using HonlineCoreMVC.Helper;
using HonlineCoreMVC.Models.AccountViewModels;
using HonlineCoreMVC.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HonlineCoreMVC.Controllers
{
    [Authorize(Roles = Consts.AdminUser + "," + Consts.CustomerEndUser)]
    public class CustomerDetailsController : Controller
    {
        public CustomerDetailsController()
        {
            _customerLogicBl = new CustomerLogic();
            _loanPaymentsCalculator = new LoanPaymentsCalculator();
            _customerDetailsHelper = new CustomerDetailsHelper();
        }

        private readonly CustomerLogic _customerLogicBl;
        private readonly LoanPaymentsCalculator _loanPaymentsCalculator;
        private readonly CustomerDetailsHelper _customerDetailsHelper;


        //Get CustomerDetails/Index
        public async Task<IActionResult> Index(string userId)
        {
            if (string.IsNullOrWhiteSpace(userId))
            {
                userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            }
            var customerDetailsViewModel = _customerDetailsHelper.GetCustomerDetailsViewModel(userId.Trim());
            return View(customerDetailsViewModel);
        }
    }
}