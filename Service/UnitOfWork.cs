using Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    /// <summary>
    /// 在需要保存数据的地方使用_unitofwork.Commit
    /// 前提是使用了ninject等依赖注入工具，可以直接使用
    /// </summary>
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        #region 数据上下文

        private DbContext context = new MyConfig().db;
        /// <summary>
        /// 数据上下文
        /// </summary>
        public DbContext _Context
        {
            get
            {
                context.Configuration.ValidateOnSaveEnabled = false;
                return context;
            }
        }

        #endregion

        /// <summary>
        /// 提交
        /// </summary>
        /// <returns></returns>
        public bool Commit()
        {
            return _Context.SaveChanges() > 0;
        }

        public void Dispose()
        {
            if (_Context != null)
            {
                _Context.Dispose();
            }
            GC.SuppressFinalize(this);
        }
    }
}
