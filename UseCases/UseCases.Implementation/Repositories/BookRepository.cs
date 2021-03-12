using DataAccess.Interfaces;
using Entities;
using UseCases.Interfaces;

namespace UseCases.Implementation
{
    internal class BookRepository:RepositoryBase<Book>,IBookRepository
    {
        public BookRepository(IBookSystemContext context):base(context)
        {

        }
    }
}
