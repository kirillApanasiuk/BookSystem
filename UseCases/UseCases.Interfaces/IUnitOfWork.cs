using System.Threading.Tasks;
using UseCases.Interfaces;

namespace UseCases.Interfaces
{
    public interface IUnitOfWork
    {
        IAuthorRepository Author { get; }
        IBookRepository Book { get; }
        IPromotionalPriceRepository PricePromo { get; }
        IRewiewRepository Rewiew { get; }
        public int Save();
    }
}
