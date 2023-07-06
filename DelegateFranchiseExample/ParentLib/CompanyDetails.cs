using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParentLib
{
    public delegate string GetCompanyNameDelegate();
    public class CompanyDetails
    {
        public event GetCompanyNameDelegate myevent;
        public GetCompanyNameDelegate GetCompDelegate { get; set; }
        public string caller()
        {
            myevent();
            return GetCompDelegate();
        }
        //public string GetCompanyNmae()
        //{
        //    return "anusha company";
        //}
    }
}
