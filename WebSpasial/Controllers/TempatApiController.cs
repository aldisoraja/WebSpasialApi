using Microsoft.AspNetCore.Mvc;
using WebSpasial.EfCore;
using WebSpasial.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebSpasial.Controllers
{
    [Route("api/[action]")]
    [ApiController]
    public class TempatApiController : ControllerBase
    {
        private readonly DbHelper _db;
        private ResponseType type;

        public TempatApiController(EF_DataContext eF_DataContext)
        {
            _db = new DbHelper(eF_DataContext);
        }

        // GET: api/<TempatController>
        [HttpGet]
        [Route("WebSpasial")]
        public IActionResult Get()
        {
            type = ResponseType.Success;
            try
            {
                IEnumerable<TempatModel> data = _db.GetTempats();

                if(!data.Any())
                {
                    type = ResponseType.NotFound;
                }
                return Ok(ResponseHandler.GetAppResponse(type, data));
            }
            catch (Exception ex)
            {
                return BadRequest(ResponseHandler.GetExceptionResponse(ex));
            }
        }

        // GET api/<TempatController>/
        [HttpGet]
        [Route("WebSpasial/{id}")]
        public IActionResult Get(int id)
        {
            type = ResponseType.Success;
            try
            {
                TempatModel data = _db.GetTempatsById(id);

                if (data == null)
                {
                    type = ResponseType.NotFound;
                }
                return Ok(ResponseHandler.GetAppResponse(type, data));
            }
            catch (Exception ex)
            {
                return BadRequest(ResponseHandler.GetExceptionResponse(ex));
            }
        }

        // POST api/<TempatController>
        [HttpPost]
        [Route("WebSpasial/TambahData")]
        public IActionResult Post([FromBody] TempatModel model)
        {
            try
            {
                type = ResponseType.Success;
                _db.SaveTempat(model);
                return Ok(ResponseHandler.GetAppResponse(type, model));
            }
            catch (Exception ex)
            {
                return BadRequest(ResponseHandler.GetExceptionResponse(ex));
            }
        }

        // PUT api/<TempatController>/5
        [HttpPut]
        [Route("WebSpasial/UbahData/{id}")]
        public IActionResult Put([FromBody] TempatModel model)
        {
            try
            {
                type = ResponseType.Success;
                _db.SaveTempat(model);
                return Ok(ResponseHandler.GetAppResponse(type, model));
            }
            catch (Exception ex)
            {
                return BadRequest(ResponseHandler.GetExceptionResponse(ex));
            }
        }

        // DELETE api/<TempatController>/5
        [HttpDelete]
        [Route("WebSpasial/HapusData/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                type = ResponseType.Success;
                _db.DeleteTempat(id);
                return Ok(ResponseHandler.GetAppResponse(type, "Delete Successfully"));
            }
            catch (Exception ex)
            {
                return BadRequest(ResponseHandler.GetExceptionResponse(ex));
            }
        }
    }
}
