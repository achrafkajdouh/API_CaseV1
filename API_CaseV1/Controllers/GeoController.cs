/*
using MaxMind.GeoIP2;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_CaseV1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeoController : ControllerBase
    {
        [HttpGet("[action']/{ipAddress}")]
        public IActionResult GetCountry(string ipAddress)
        {
            using (var reader = new DatabaseReader(@"C:\Users\Achraf\source\repos\API_CaseV1\DB\geo.mmd"))
            {
                var response = reader.Country("ipAddress");

                return StatusCode(StatusCodes.Status200OK, response.Country.Name);
            }
        }
    }
}
*/