using Business.Abstract;
using Core.Entities;
using Core.Utilities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenericBaseController<TEntity,TService> : ControllerBase where TService:IServices<TEntity> where TEntity : class,IEntity,new()
    {
        protected TService _tService;

        public GenericBaseController(TService tService) => this._tService = tService;

        [HttpGet("getall")]
        public virtual IActionResult GetAll() => GetResponseByResultSuccess(_tService.GetAll());

        [HttpGet("getbyid")]
        public virtual IActionResult GetByID(int id) => GetResponseByResultSuccess(_tService.GetById(id));

        [HttpPost("add")]
        public virtual IActionResult Add(TEntity entity) => GetResponseByResultSuccess(_tService.Add(entity));

        [HttpPost("update")]
        public virtual IActionResult Update(TEntity entity) => GetResponseByResultSuccess(_tService.Update(entity));

        [HttpPost("delete")]
        public virtual IActionResult Delete(TEntity entity) => GetResponseByResultSuccess(_tService.Delete(entity));

        protected IActionResult GetResponseByResultSuccess(IResult result)
        {
            if (result.Success) {
                return Ok(result);
            } 
            return  BadRequest(result);
        }
    }
}
