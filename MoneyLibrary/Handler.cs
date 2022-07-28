using Ninject;

namespace MoneyLibrary
{
    public class Handler : IHandler
    {
        public readonly IRepository Repository;

        public Handler(IRepository repository)
        {
            Repository = repository;
        }
    }
}