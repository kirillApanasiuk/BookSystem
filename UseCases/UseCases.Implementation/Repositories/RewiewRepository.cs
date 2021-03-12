
using DataAccess.Interfaces;
using Entities;
using UseCases.Interfaces;

namespace UseCases.Implementation
{
   internal class RewiewRepository:RepositoryBase<Rewiew>,IRewiewRepository
    {
        public RewiewRepository(IBookSystemContext context):base(context)
        {

        }
    }
}
