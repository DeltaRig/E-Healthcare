using EHealthcare.Entities;
using Microsoft.AspNetCore.Mvc;
using ProjectManagement.Data;
using System.Collections.Generic;
using System.Linq;

namespace Ehealthcare.Api.Controllers
{
    [ApiController]
    public class MedicineController : Controller
    {
        private IBaseRepository<Product> ProductRepo { get; set; }
        public MedicineController(IBaseRepository<Product> repository)
        {
            ProductRepo = repository;
        }

        [HttpGet("search/{uses}")]
        public List<Product> SearchMedicineByDisease(string uses)
        {
            return ProductRepo.Get().Where(p => p.Uses.Contains(uses)).ToList();
        }

        [HttpGet("getAllMedicine")]
        public List<Product> GetAll()
        {
            return ProductRepo.Get().ToList();
        }
    }
}
