using EmployeeManagement.DAL.UOW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.BAL.Services
{
    public class ServiceBase : IDisposable
    {
        protected static UnitOfWork UnitOfWorks = new UnitOfWork();
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            GC.SuppressFinalize(this);
        }
    }
}