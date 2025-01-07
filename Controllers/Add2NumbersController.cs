
using Microsoft.AspNetCore.Mvc;

namespace BatresA.MC_2Add2Numbers_Endpoint.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Add2NumbersController : ControllerBase
    {
        // The constructor runs first when the api is called
        // Web API version of void start


        [HttpGet] //Use HttpPost for adding Information to the backend
        [Route("AddNumbers/{num1}/{num2}")] //To pass data through our routes we add /{parameter
        public string Add2Nums(int num1, int num2)
        {
            int sum = num1 + num2;
            return $"{num1} + {num2} is equal to {sum}";
        }

    }
}
