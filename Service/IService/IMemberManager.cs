﻿using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.IService
{
    public interface IMemberManager:IRepository<Domain.Model.Member>
    {
    }
}
