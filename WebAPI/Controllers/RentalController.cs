using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalController : GenericBaseController<Rental, IRentalService>
    {
        public RentalController(IRentalService tService) : base(tService)
        {
        }
    }
}
