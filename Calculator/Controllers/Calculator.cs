using Microsoft.AspNetCore.Mvc;

namespace Calculator.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Calculator : ControllerBase
    {
        [HttpGet("add")]
        public ActionResult<double> Add(double a, double b)
        {
            return Ok(a + b);
        }

        [HttpGet("subtract")]
        public ActionResult<double> Subtract(double a, double b)
        {
            return Ok(a - b);
        }

        [HttpGet("multiply")]
        public ActionResult<double> Multiply(double a, double b)
        {
            return Ok(a * b);
        }

        [HttpGet("divide")]
        public ActionResult<double> Divide(double a, double b)
        {
            if (b == 0)
                return BadRequest("Cannot divide by zero.");

            return Ok(a / b);
        }
    }
}

