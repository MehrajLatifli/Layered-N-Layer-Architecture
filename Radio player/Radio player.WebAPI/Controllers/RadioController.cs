using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Radio_player._Entities.Concrete.DatabaseFirst;
using Radio_player.Business.Abstract;
using Radio_player.Mapper;

namespace Radio_player.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RadioController : ControllerBase
    {
        private IRadioService _radioService;

        public RadioController(IRadioService radioService)
        {
            _radioService = radioService;
        }

        //Radio CRUD
        #region

        [HttpGet("radio")]
        public async Task<IActionResult> GetRadio()
        {
            return Ok(_radioService.GetAll());
        }


        [HttpGet("radio/{id?}")]
        public IActionResult GetRadioId(int id)
        {
            var item = _radioService.GetById(id);

            try
            {
                if (item == null)
                {

                    return StatusCode(StatusCodes.Status404NotFound);
                }

                else
                {
                    return Ok(_radioService.GetAll().Where(o => o.IdRadio == id));
                }
            }
            catch (Exception)
            {

            }
            return BadRequest();

        }


        [HttpPost("radio")]
        public async Task<IActionResult> PostRadio([FromBody] RadioDTO item)
        {

            try
            {

                Radio radio = new Radio()
                {
                    RadioCountry = item.RadioCountry,
                    RadioFile = item.RadioFile,
                    RadioName = item.RadioName,
                    ImageRadio = item.ImageRadio,
                };

                _radioService.Add(radio);

                return StatusCode(StatusCodes.Status201Created);
            }
            catch (Exception)
            {


            }
            return BadRequest();

        }


        [HttpPut("radio")]
        public async Task<IActionResult> UpdateRadio([FromBody] Radio item)
        {
            try
            {


                _radioService.Update(item);

                //return StatusCode(StatusCodes.Status200OK);

                return StatusCode(StatusCodes.Status204NoContent);
            }
            catch (DbUpdateConcurrencyException ex)
            {
                throw ex;

            }
            return BadRequest();

        }

        [HttpDelete("radio/{id}")]
        public async Task<IActionResult> DeleteRadio(int id)
        {
            try
            {
                _radioService.Delete(new Radio { IdRadio = id });

                return StatusCode(StatusCodes.Status204NoContent);
            }
            catch (Exception)
            {


            }
            return BadRequest();

        }

        #endregion
    }
}
