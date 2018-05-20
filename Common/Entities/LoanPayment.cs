using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Common.Entities
{
    public class LoanPayment
    {
        [Display(Name = "Interest")]
        [DisplayFormat(DataFormatString = "₪{0:#.##}")]
        public double InterestForMonth { get; set; }

        [Display(Name = "Principal")]
        [DisplayFormat(DataFormatString = "₪{0:#.##}")]
        public double PrincipalForMonth { get; set; }

        [Display(Name = "Balance")]
        [DisplayFormat(DataFormatString = "₪{0:#.##}")]
        public double Balance { get; set; }

        [Display(Name = "Monthy payment")]
        [DisplayFormat(DataFormatString = "₪{0:#.##}")]
        public double MonthyPayment { get; set; }

        public int Index { get; set; }
    }
}
