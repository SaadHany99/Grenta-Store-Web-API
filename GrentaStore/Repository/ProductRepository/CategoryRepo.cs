using GrentaStore.Models;
using GrentaStore.Models.Data;
using Microsoft.EntityFrameworkCore;

namespace GrentaStore.Repository.ProductRepository
{
    public class CategoryRepo:ICategoryRepo
    {
        GrentaDbContext db;

        public CategoryRepo(GrentaDbContext db)
        {
            this.db = db;
        }
        public List<Category> GetAll()
        {
            return db.categories.ToList();
        }

        public List<Product> GetUserCardsById(string id)
        {
            var s=  db.userProducts.Include(x=> x.product).Where(x => x.UserId == id).Select(x=>x.product).ToList();
            return s;
        }

        public Category GetById(int id) 
        {
            return db.categories.Find(id);        
        }

        public void AddToCart(UserProducts userProduct)
        {
            
            db.userProducts.Add(userProduct);
            db.SaveChanges();
        }

        public void DeleteCart(int id)
        {
            var userProduct = db.userProducts.FirstOrDefault(x => x.Id == id);
            db.userProducts.Remove(userProduct);
            db.SaveChanges();
        }
    }
}
