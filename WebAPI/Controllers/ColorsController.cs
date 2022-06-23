using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorsController : GenericBaseController<Color, IColorService>
    {
        public ColorsController(IColorService colorService) : base(colorService)
        {
        }
    }
}       
