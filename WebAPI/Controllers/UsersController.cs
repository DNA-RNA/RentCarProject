using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : GenericBaseController<User, IUserService>
    {
        public UsersController(IUserService tService) : base(tService)
        {
        }
    }
}
