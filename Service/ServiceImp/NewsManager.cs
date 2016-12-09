using Common.CryptHelper;
using Domain.Model;
using Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.ServiceImp
{
    public class NewsManager : RepositoryBase<Domain.Model.News>, INewsManager
    {
    }
}
