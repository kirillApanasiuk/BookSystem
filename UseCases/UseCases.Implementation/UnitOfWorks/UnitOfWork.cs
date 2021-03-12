using DataAccess.Interfaces;
using UseCases.Interfaces;

namespace UseCases.Implementation.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IBookSystemContext _context;
        private IAuthorRepository _authorRepository;
        private IBookRepository _bookRepository;
        private IPromotionalPriceRepository _pricePromoRepository;
        private IRewiewRepository _rewiewRepository;

        public UnitOfWork(IBookSystemContext context)
        {
            _context = context;
        }
        public IAuthorRepository Author {
            get {
                if (_authorRepository == null)
                    _authorRepository = new AuthorRepository(_context);
                return _authorRepository;
            }
        }

        public IBookRepository Book
        {
            get
            {
                if (_bookRepository == null)
                    _bookRepository = new BookRepository(_context);
                return _bookRepository;
            }
        }

        public IPromotionalPriceRepository PricePromo
        {
            get
            {
                if (_pricePromoRepository == null)
                    _pricePromoRepository = new PromotionalPriceRepository(_context);
                return _pricePromoRepository;
            }
        }

        public IRewiewRepository Rewiew
        {
            get
            {
                if (_rewiewRepository == null)
                    _rewiewRepository = new RewiewRepository(_context);
                return _rewiewRepository;
            }
        }

        public int Save()
        {
            return _context.SaveChanges();
        }
    }
}
