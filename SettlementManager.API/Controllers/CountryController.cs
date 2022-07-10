using Microsoft.AspNetCore.Mvc;
using SettlementManager.Contract;
using SettlementManager.Messaging.Request;
using SettlementManager.Messaging.View;

namespace SettlementManager.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CountryController : ControllerBase
	{
		#region Fields

		private readonly ICountryService _countryService;

		#endregion

		#region Constructors

		public CountryController(ICountryService countryService)
		{
			_countryService = countryService;
		}

		#endregion

		#region CountryController

		[HttpGet("GetCountries")]
		public async Task<ActionResult<IEnumerable<CountryView>>> GetAvailableCountriesAsync()
		{
			var response = await _countryService.GetCountriesAsync(new GetCountriesRequest());

			return Ok(response.Countries);
		}

		#endregion
	}
}
