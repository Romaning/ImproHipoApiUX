using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistence.DbContexts;

namespace Infrastructure.Gateways.Injections
{
    public class DependencyInjectContext
    {
        protected ApplicationDbImproContext _dbImproContext;
        protected ApplicationDbHipoContext _dbHipoContext;
        protected ApplicationDbAuxContext _dbAuxContext;

        public ApplicationDbImproContext dbImproContext
        {
            get
            {
                return _dbImproContext ?? new ApplicationDbImproContext();
            }
            private set
            {
                _dbImproContext = value;
            }
        }
        public ApplicationDbHipoContext dbHipoContext
        {
            get
            {
                return _dbHipoContext ?? new ApplicationDbHipoContext();
            }
            private set
            {
                _dbHipoContext = value;
            }
        }
        public ApplicationDbAuxContext dbAuxContext
        {
            get
            {
                return _dbAuxContext ?? new ApplicationDbAuxContext();
            }
            private set
            {
                _dbAuxContext = value;
            }
        }

        public DependencyInjectContext(ApplicationDbImproContext _dbImproContexts, ApplicationDbHipoContext _dbHipoContexts, ApplicationDbAuxContext _dbAuxContexts)
        {
            dbImproContext = _dbImproContexts;
            dbHipoContext = _dbHipoContexts;
            dbAuxContext = _dbAuxContexts;
        }
    }
}
