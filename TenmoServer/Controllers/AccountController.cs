using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TenmoServer.DAO;

namespace TenmoServer.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountDAO AccountDAO;

        public AccountController(IAccountDAO accountDAO)
        {
            AccountDAO = accountDAO;
        }

        [HttpGet]
        public ActionResult<decimal> GetBalance(int userId)
        {
            return AccountDAO.GetBalance(userId);
        }
    }
}
