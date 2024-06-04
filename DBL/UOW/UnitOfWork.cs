using DBL.Repositories;

namespace DBL.UOW
{
    public class UnitOfWork : IUnitOfWork
    {
        private string connString;
        private bool _disposed;

        private ISecurityRepository securityRepository;
        private ICategoryRepository categoryRepository;
        private IProductRepository productRepository;

        public UnitOfWork(string connectionString) => connString = connectionString;

        public ISecurityRepository SecurityRepository
        {
            get { return securityRepository ?? (securityRepository = new SecurityRepository(connString)); }
        }
        public ICategoryRepository CategoryRepository
        {
            get { return categoryRepository ?? (categoryRepository = new CategoryRepository(connString)); }
        }
        public IProductRepository ProductRepository
        {
            get { return productRepository ?? (productRepository = new ProductRepository(connString)); }
        }


        public void Reset()
        {
            securityRepository = null;
            categoryRepository = null;
            productRepository = null;
        }

        public void Dispose()
        {
            dispose(true);
            GC.SuppressFinalize(this);
        }

        private void dispose(bool disposing)
        {
            if (!_disposed)
            {
                _disposed = true;
            }
        }

        ~UnitOfWork()
        {
            dispose(false);
        }
    }
}
