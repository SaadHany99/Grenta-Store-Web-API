using GrentaStore.Models;
using GrentaStore.Repository.ProductRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GrentaStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IProductRepo<Product> productRepo;
        ICategoryRepo categoryRepo;
        public ProductsController(IProductRepo<Product> productRepo,ICategoryRepo categoryRepo)
        {
            this.productRepo = productRepo;
            this.categoryRepo=categoryRepo;
        }

        [HttpGet]
        public IActionResult GetAllProducts() 
        {
            List<Product> products= productRepo.GetAll();
            return Ok(products);
        }
        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            Product product= productRepo.GetById(id);
            if(product==null)
            {
                return NotFound();
            }else
            return Ok(product);
        }
        [HttpPost]
        public IActionResult AddProduct(Product product) 
        {
            if (product == null)
            {
                return BadRequest();
            }
            productRepo.Insert(product);
            productRepo.Save();
            return Ok();
        }
        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id,Product product) 
        {
            if(product == null)
            {
                return BadRequest();
            }
            productRepo.editProduct(id, product);
            productRepo.Save();
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            Product product = productRepo.GetById(id);
            if( product!=null)
            {
                productRepo.Delete(id);
                productRepo.Save();
                return Ok();
            }else
                return NotFound();
            
        }

        [HttpGet]
        [Route("categ")]
        public IActionResult GetAllCateg()
        {
            List<Category> categories = categoryRepo.GetAll();
            return Ok(categories);
        }

        [HttpGet]
        [Route("UserCards/{id}")]
        public IActionResult GetAllUserCardsById(string id)
        {
            var cardsUser= categoryRepo.GetUserCardsById(id);
            return Ok(cardsUser);
        }

        [HttpPost]
        [Route("AddToCart")]
        public IActionResult AddToCart([FromBody] UserProducts userProduct)
        {
            categoryRepo.AddToCart(userProduct);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteCart([FromBody]int id)
        {
            categoryRepo.DeleteCart(id);
            return Ok();
        }

    }

}
