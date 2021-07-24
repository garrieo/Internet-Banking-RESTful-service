using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Internet_Banking_RESTful_service.Api
{
   public interface IInternetBankingApi
    {
        public ActionResult GetApiVersion();
        public ActionResult CalculateMD5(string input);
        public ActionResult IsPasswordStrong(string password);
    }
}
