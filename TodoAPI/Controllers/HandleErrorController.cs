using Microsoft.AspNetCore.Components;

namespace TodoAPI.Controllers
{
    [Route("/error")]   
    public IActionResult HandleError() => Problem();
}
