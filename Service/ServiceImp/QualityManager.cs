﻿using Common.CryptHelper;
using Domain.Model;
using Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.ServiceImp
{
    public class QualityManager : RepositoryBase<Domain.Model.Quality>, IQualityManager
    {
    }
}
