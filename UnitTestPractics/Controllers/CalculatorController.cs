using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UnitTestPractics.Services;

namespace UnitTestPractics.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CalculatorController : ControllerBase
	{
		private readonly ICalculatorService _calculatorService;
		public CalculatorController(ICalculatorService calculatorService)
		{
			_calculatorService = calculatorService;
		}

		[HttpPost]
		[Route("Add")]
		public double Add(double x1, double x2)
		{
			return _calculatorService.Add(x1, x2);
		}
		[HttpPost]
		[Route("Divide")]
		public double Divide(double x1, double x2)
		{
			return _calculatorService.Divide(x1, x2);
		}
		[HttpPost]
		[Route("Multiply")]
		public double Multiply(double x1, double x2)
		{
			return _calculatorService.Multiply(x1, x2);
		}
		[HttpPost]
		[Route("Subtract")]
		public double Subtract(double x1, double x2)
		{
			return _calculatorService.Subtract(x1, x2);
		}
	}
}
