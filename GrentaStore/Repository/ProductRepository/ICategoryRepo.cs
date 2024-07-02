using GrentaStore.Models;

namespace GrentaStore.Repository.ProductRepository
{
    public interface ICategoryRepo
    {
        List<Category> GetAll();
        Category GetById(int id);
        List<Product> GetUserCardsById(string id);
        void AddToCart(UserProducts userProduct);
        void DeleteCart(int id);
    }
}
