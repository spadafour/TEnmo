﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TenmoServer.DAO
{
    public interface IAccountDAO
    {
        decimal GetBalance(int userId);
        //decimal AddFunds(int accountId);
        //decimal RemoveFunds(int accountId);
    }
}
