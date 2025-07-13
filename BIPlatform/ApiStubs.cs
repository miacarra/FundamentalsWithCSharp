using Microsoft.AspNetCore.Mvc;

namespace TourismBI.Api
{
    // Примерни контролери без реални имплементации

    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        [HttpPost("register")]
        public IActionResult Register([FromBody] ApiModels.RegisterRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok();
        }

        [HttpPost("login")]
        public IActionResult Login() => Ok();
    }

    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetProfile() => Ok();
    }

    [ApiController]
    [Route("api/[controller]")]
    public class TouristPlacesController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll() => Ok();
    }

    [ApiController]
    [Route("api/[controller]")]
    public class ReviewsController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateReview() => Ok();
    }

    [ApiController]
    [Route("api/[controller]")]
    public class RecommendationsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetRecommendations() => Ok();
    }

    [ApiController]
    [Route("api/[controller]")]
    public class AnalyticsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAnalytics() => Ok();
    }

    [ApiController]
    [Route("api/[controller]")]
    public class AuthoritiesController : ControllerBase
    {
        [HttpGet("heatmap")]
        public IActionResult HeatMap() => Ok();
    }

    [ApiController]
    [Route("api/[controller]")]
    public class SignalsController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateSignal() => Ok();
    }

    [ApiController]
    [Route("api/[controller]")]
    public class FilesController : ControllerBase
    {
        [HttpPost]
        public IActionResult Upload() => Ok();
    }

    [ApiController]
    [Route("api/[controller]")]
    public class WeatherController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetForecast() => Ok();
    }
}
