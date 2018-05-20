using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bl;
using HonlineCoreMVC.Common.DTO;
using HonlineCoreMVC.Common.Utility;
using HonlineCoreMVC.Helper;
using HonlineCoreMVC.Models.AccountViewModels;
using HonlineCoreMVC.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HonlineCoreMVC.Controllers
{
    [Authorize(Roles = Consts.AdminUser)]
    public class AgentController : Controller
    {
        public AgentController()
        {
            _customerLogic = new CustomerLogic();
            _loanPaymentsCalculator = new LoanPaymentsCalculator();
            _customerDetailsHelper = new CustomerDetailsHelper();
        }

        private readonly CustomerLogic _customerLogic;
        private readonly LoanPaymentsCalculator _loanPaymentsCalculator;
        private readonly CustomerDetailsHelper _customerDetailsHelper;

        //Get Agent/Index
        public IActionResult Index()
        {
            var users = _customerLogic.GetApplicationUsers();

            var UsersDTO = new List<UserDTO>();

            foreach (var user in users)
            {
                UsersDTO.Add
                    (new UserDTO
                    {
                        Id = user.Id,
                        FirstName = user.FirstName,
                        LastName = user.LastName,
                        Email = user.Email,
                    });
            }
            return View(UsersDTO);
        }
        //Get Agent/GetCustomerDetails
        [HttpGet]
        public IActionResult GetCustomerDetails(string userId)
        {        
            var viewModel = _customerDetailsHelper.GetCustomerDetailsViewModel(userId.Trim());
            return PartialView("_CustomerDetails", viewModel);
        }
    }
}