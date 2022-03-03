using Microsoft.AspNetCore.Mvc;

namespace ReStore.Controllers
{
    public class BuggyController : BaseApiController
    {
        [HttpGet("not-found")]
        public ActionResult GetNotFound()
        {
            return NotFound();
        }

        [HttpGet("bad-request")]
        public ActionResult GetBadRequest()
        {
            return BadRequest(new ProblemDetails {Title = "This is bad request"});
        }

        [HttpGet("unauthorized")]
        public ActionResult GetUnAuthorize()
        {
            return Unauthorized();
        }

        [HttpGet("validation-error")]
        public ActionResult GetValidationError()
        {
            ModelState.AddModelError("Problem1", "This is first problem");
            ModelState.AddModelError("Problem2", "This is second problem");
            return ValidationProblem();
        }

        [HttpGet("server-error")]
        public ActionResult GetServerError()
        {
            throw new Exception("This is server error");
        }
    }
}
