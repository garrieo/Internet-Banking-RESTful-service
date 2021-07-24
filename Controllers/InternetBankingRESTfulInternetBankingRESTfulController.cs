using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Internet_Banking_RESTful_service.Api;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Internet_Banking_RESTful_service.Controllers
{

    public class InternetBankingRESTfulController : ControllerBase, IInternetBankingApi
    {
       

        [HttpGet]
        [Route("bank/api/calc/MD5/{input}")]
        [Route("bank/api/calc/{input}/MD5")]
        public string CalculateMD5(string input)
        {

            return Helpers.CreateMD5(input);
        }

        [HttpGet]
        [Route("bank/api/version")]
        [Route("bank/api-version")]
        public string GetApiVersion()
        {
            return string.Format("{0}.1.0", DateTime.UtcNow.ToString("yyyy.MM.dd"));
        }

        [HttpGet]
        [Route(" bank/api/password/strong/{input}")]
        [Route(" bank/api/is-password-strong/{input}")]
        public bool IsPasswordStrong(string password)
        {
            throw new NotImplementedException();
        }


        
    }
}
