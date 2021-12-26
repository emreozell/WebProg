using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebOdev.Data;
using WebOdev.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebOdev.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodApiController : ControllerBase
    {
        private readonly ApplicationDbContext k;

        public FoodApiController(ApplicationDbContext nesne)
        {
            k = nesne;
        }

        // GET: api/<CategoriesApiController>
        [HttpGet]
        public List<Food> Get()
        {
            return k.Foods.ToList();
        }

        // GET api/<CategoriesApiController>/5
        [HttpGet("{id}")]
        public Food Get(int id)
        {
            var y = k.Foods.FirstOrDefault(x => x.FoodID == id);
            return y;
        }

        // POST api/<CategoriesApiController>
        [HttpPost]
        public void Post([FromBody] Food y)
        {
            k.Foods.Add(y);
            k.SaveChanges();
        }

        // PUT api/<CategoriesApiController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Food y)
        {
            var y1 = k.Foods.FirstOrDefault(x => x.FoodID == id);

            if (y1 is null)
            {
                return NotFound();
            }
            else
            {
                y1.Name = y.Name;
                y1.Description = y.Description;
                y1.Price = y.Price;
                y1.Stock = y.Stock;
                y1.Resim = y.Resim;
                y1.CategoryID = y.CategoryID;
                y1.Category = y.Category;
                y1.ImageFile = y.ImageFile;
                
                k.Update(y1);
                k.SaveChanges();
                return Ok();
            }
        }

        // DELETE api/<CategoriesApiController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var y1 = k.Foods.FirstOrDefault(s => s.FoodID == id);

            if (y1 is null)
            {
                return NotFound();
            }
            else
            {
                k.Remove(y1);
                k.SaveChanges();
                return Ok();
            }
        }
    }
}
