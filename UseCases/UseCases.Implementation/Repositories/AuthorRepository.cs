using DataAccess.Interfaces;
using Entities;
using UseCases.Interfaces;

namespace UseCases.Implementation
{
    internal class AuthorRepository: RepositoryBase<Author>,IAuthorRepository
    {
        public AuthorRepository(IBookSystemContext context):base(context)
        {

        }
    }
}
