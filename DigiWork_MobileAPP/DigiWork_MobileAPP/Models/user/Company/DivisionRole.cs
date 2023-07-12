using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigiWork_MobileAPP.Models.user.Company
{
    public class DivisionRole
    {
        public string DivisionRoleID { get; set; }
        public string NameOfRole { get; set; }
        public Job Job { get; set; }
    }
}
