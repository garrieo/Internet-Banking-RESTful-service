using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Internet_Banking_RESTful_service.Api
{
   public interface IInternetBankingApi
    {
        public string GetApiVersion();
        public string CalculateMD5(string input);
        public bool IsPasswordStrong(string password);
    }
}
