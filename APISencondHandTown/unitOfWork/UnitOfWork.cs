
using APISencondHandTown.Models;
using APISencondHandTown.unitOfWork.Repositories;

namespace APISencondHandTown.unitOfWork
{
    public interface IUnitOfWork
    {
        IRepository<User> UserRepository { get; }
        IRepository<Product> ProductRepository { get; }

        void SaveChanges();
    }

    public class UnitOfWork : IUnitOfWork
    {
        private DB_TMDTContext context;

        public UnitOfWork(DB_TMDTContext context)
        {
            this.context = context;
        }

        private IRepository<User> userRepository;
        public IRepository<User> UserRepository
        {
            get
            {
                if (userRepository == null)
                {
                    userRepository = new UserRepository(context);
                }

                return userRepository;
            }
        }
        private IRepository<Product> productRepository;
        public IRepository<Product> ProductRepository
        {
            get
            {
                if (productRepository == null)
                {
                    productRepository = new ProductRepository(context);
                }

                return productRepository;
            }
        }
        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
