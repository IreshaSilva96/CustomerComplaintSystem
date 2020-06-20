using System;
using CustomerComplaintSystem.Entities;
using CustomerComplaintSystem.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CustomerComplaintSystem.Controllers
{
    [Route("api/productandservice")]
    [ApiController]

    public class ProductAndServiceController : ControllerBase
    {
        IProductAndServiceInterface _productAndServiceRepo;

        public ProductAndServiceController(IProductAndServiceInterface productAndServiceRepo)
        {
            _productAndServiceRepo = productAndServiceRepo;
        }


//Action Methods

        [HttpGet]
        public IActionResult GetAllProductAndServices()
        {
            var productsAndService = _productAndServiceRepo.GetAllProductsAndServices();
            return Ok(productsAndService);
        }


        [HttpGet("search/{ProductAndServiceID}")]
        public IActionResult GetProductAndServiceByID(int ProductAndServiceID)
        {
            if (ProductAndServiceID < 0)
            {
                BadRequest();
            }
            var productAndService = _productAndServiceRepo.GetProductAndServiceByID(ProductAndServiceID);
            return Ok(productAndService);
        }


        [HttpPost("create")]
        public IActionResult CreateProductAndService([FromBody] ProductAndService NewProductAndService)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            if (NewProductAndService == null)
            {
                return BadRequest();
            }

            _productAndServiceRepo.CreateProductAndService(NewProductAndService);
            return Ok();
        }


        [HttpPut("update/{ProductAndServiceID}")]
        public IActionResult UpdateProductAndService(int ProductAndServiceID, [FromBody] ProductAndService ProductAndServiceObject)
        {
            if (ProductAndServiceID < 0)
            {
                return BadRequest();
            }

            int result = _productAndServiceRepo.UpdateProductAndService(ProductAndServiceID, ProductAndServiceObject);
            if (result == 0)
            {
                return BadRequest();
            }
            else
            {
                return Ok();
            }
        }


        [HttpDelete("delete/{ProductAndServiceID}")]
        public IActionResult DeleteProductAndService(int ProductAndServiceID)
        {
            if (ProductAndServiceID < 0)
            {
                return BadRequest();
            }
            _productAndServiceRepo.DeleteProductAndService(ProductAndServiceID);

            return Ok();
        }
    }
}
