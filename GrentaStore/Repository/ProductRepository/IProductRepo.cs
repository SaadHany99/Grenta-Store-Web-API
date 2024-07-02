namespace GrentaStore.Repository.ProductRepository
{
    public interface IProductRepo<T>
    {
        List<T> GetAll();
        T GetById(int id);
        void Insert(T item);
        void editProduct(int id,T item);
        void Delete(int id);
        void Save();
        
    }
}
