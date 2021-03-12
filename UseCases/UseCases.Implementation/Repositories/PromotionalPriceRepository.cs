using DataAccess.Interfaces;
using Entities;
using UseCases.Interfaces;

namespace UseCases.Implementation
{
    internal class PromotionalPriceRepository : RepositoryBase<PromotionalPrice>, IPromotionalPriceRepository
    {
        public PromotionalPriceRepository(IBookSystemContext context) : base(context)
        {

        }
    }
}
