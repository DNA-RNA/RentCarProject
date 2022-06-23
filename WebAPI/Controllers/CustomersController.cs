using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : GenericBaseController<Customer, ICustomerService>
    {
        public CustomersController(ICustomerService tService) : base(tService)
        {
        
        }
    }
}
