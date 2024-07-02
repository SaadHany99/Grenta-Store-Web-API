using GrentaStore.Models;
using GrentaStore.Models.Data;

namespace GrentaStore.Repository.ProductRepository
{
    public class ProductRepo : IProductRepo<Product>
    {
        GrentaDbContext db;

        public ProductRepo(GrentaDbContext db)
        {
            this.db = db;
        }

        public void Delete(int id)
        {
            Product pro = db.products.Find(id);
            if(pro != null)
            {
                db.products.Remove(pro);
            }
        }

        public List<Product> GetAll()
        {
            return db.products.ToList();
        }

        public Product GetById(int id)
        {
            return db.products.Find(id);
        }

        public void Insert(Product item)
        {
            if(item!=null)
            db.products.Add(item);

        }

        public void editProduct(int id, Product item)
        {
            //Product prod = db.products.Find(id);
            //if (prod != null)
            //{
            //    prod.Name = item.Name;
            //    prod.Description = item.Description;
            //    prod.Price = item.Price;
            //    prod.Quantity = item.Quantity;
            //    prod.Image = item.Image;
            //    prod.Categ_Id = item.Categ_Id;
            //}
            item.Id = id;
            db.products.Update(item);
            //db.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
        public void Save()
        {
            db.SaveChanges();
        }
    }
}
