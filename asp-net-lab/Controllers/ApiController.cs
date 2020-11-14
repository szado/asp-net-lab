using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using asp_net_lab.Models;

namespace asp_net_lab.Controllers
{
    [Route("api/company")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        public CompanyModel Post(CompanyModel companyModel)
        {
            return companyModel;
        }
    }
}
