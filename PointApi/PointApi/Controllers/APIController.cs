using Microsoft.AspNetCore.Mvc;
using PointApi.Models;

namespace PointApi.Controllers
{
    public class APIController : ControllerBase
    {
        ICalculateSlope _calculateSlope;

        public APIController(ICalculateSlope calculateSlope)
        {
            this._calculateSlope = calculateSlope;
        }


        public IActionResult Index()
        {
            return Ok("Thats Right.");
        }
        public IActionResult IsEqualSlope()
        {
            return Ok(_calculateSlope.IsEqualSlope());
        }


    }
}
