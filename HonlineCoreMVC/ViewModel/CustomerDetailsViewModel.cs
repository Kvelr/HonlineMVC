using Common.Entities;
using HonlineCoreMVC.Common.Entities;
using HonlineCoreMVC.Models.AccountViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HonlineCoreMVC.ViewModel
{
    public class CustomerDetailsViewModel
    {
        public RegisterViewModel User { get; set; }
        public List<LoanPayment> LoanPayments { get; set; }
    }
}
