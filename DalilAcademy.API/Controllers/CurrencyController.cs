using DalilAcademy.Core.Service;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DalilAcademy.Core.DTOs;
namespace DalilAcademy.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrencyController(ICurrencyService currencyService) : ControllerBase
    {
        
        [HttpPost("convert")]
        public async Task<ActionResult<ConvertPriceResponseDto>> Convert(ConvertPriceRequsetDto dto)
        {
            return Ok(await currencyService.Convert(dto));
        }
    }
}
