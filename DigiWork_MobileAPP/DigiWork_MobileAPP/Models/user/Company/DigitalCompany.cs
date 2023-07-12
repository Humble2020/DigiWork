using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigiWork_MobileAPP.Models.user.Company
{
    public class DigitalCompany
    {
        public string DigitalCompanyId { get; set; }
        public string DigitalCompanyName { get; set; }
        public string Logo { get; set; }
        public string Description { get; set; }
        public DateTime StartWorkTime { get; set; }
        public DateTime CloseWorkTime { get; set; }
        public DivisionRole DivisionRole { get; set; }
        public SalaryRange SalaryRange { get; set; }
        public string Website { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
    }
}
public enum SalaryRange
{
   FirstRange= 500 - 2000,
   SecondRange = 2001 - 6000,
   ThirdRange = 8100 - 15000,
   FourthRange = 15100 - 45000,
   FifthRange = 45100-500000
}