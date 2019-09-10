using System;
using System.Collections.Generic;
using System.Text;
using IService;
using Model;

namespace Service
{
    public class MyBalanceService:BaseService<MyBalance>,IMyBalanceService
    {
    }
}
