using Microsoft.AspNetCore.Mvc;

namespace App.Api {
    [Route("api/")]
    public class EEMUA191Rev3Controller : Controller
    {
        [HttpGet]
        [Route("GetZoneForPoint")]
        public IActionResult GetZoneForPoint(double x, double y)
        {
            return Ok(Lib.EEMUA191Rev3.GetZoneForPoint(x,y));
        }
    }
}