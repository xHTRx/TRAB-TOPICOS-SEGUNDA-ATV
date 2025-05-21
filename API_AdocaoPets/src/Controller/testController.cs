using Microsoft.AspNetCore.Mvc;

namespace API_AdocaoPets.src.Controller;

[Route("api/v1/[controller]")]
[ApiController]
public class testController : ControllerBase
{
	[HttpGet]
	public string Teste()
	{
		return "Funciona!";
	}
}