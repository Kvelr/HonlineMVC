using Bl;
using HonlineCoreMVC.Models.AccountViewModels;
using HonlineCoreMVC.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HonlineCoreMVC.Helper
{
    public class CustomerDetailsHelper
    {
        public CustomerDetailsHelper()
        {
            _customerLogic = new CustomerLogic();
            _loanPaymentsCalculator = new LoanPaymentsCalculator();
        }

        private readonly CustomerLogic _customerLogic;
        private readonly LoanPaymentsCalculator _loanPaymentsCalculator;

        public CustomerDetailsViewModel GetCustomerDetailsViewModel(string userId)
        {
            var customerDetailsViewModel = new CustomerDetailsViewModel();
            var user = _customerLogic.GetUserByID(userId.Trim());
            customerDetailsViewModel.User = new RegisterViewModel()
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Taz = user.Taz,
                BirthDate = user.BirthDate,
                LoanAmount = user.LoanAmount,
                PeriodInMonths = user.PeriodInMonths
            };

            customerDetailsViewModel.LoanPayments = _loanPaymentsCalculator.GetAmortizationSchedule(customerDetailsViewModel.User.PeriodInMonths, Convert.ToDouble(customerDetailsViewModel.User.LoanAmount));
            return customerDetailsViewModel;
        }
    }
}
