using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigiWork_MobileAPP.Models.user.Company
{
    public class Vacancy
    {
        public string VacancyId { get; set; }
        public DateTime DatePosted { get; set; }
        public string WhoAreYouLookingFor { get; set; }
        public SalaryDuration SalaryDuration { get; set; }
        public decimal SalaryAmount { get; set; }
        public PaymentType PaymentType { get; set; }
        public string PostedBy { get; set; }
        public DigitalCompany GetDigitalCompany { get; set; }

    }
}
public enum SalaryDuration
{
    Monthly,
    Weekly,
    Hourly,
    Daily
}
public enum PaymentType
{
    Bank,
    Opay,
    Bitcoin,
    Ethereum
}