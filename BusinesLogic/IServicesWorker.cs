using System;
using System.Threading.Tasks;
using Services;

namespace ServicesWorker
{
    public interface IServicesWorker
    {
        IAuthorRepository Author { get; }
        IBookRepository Book { get; }
        IPromotionalPriceRepository PricePromo { get; }
        IRewiewRepository Rewiew { get; }
        Task SaveAsync();
    }
}
