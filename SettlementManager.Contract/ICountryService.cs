using SettlementManager.Messaging.Request;
using SettlementManager.Messaging.Response;

namespace SettlementManager.Contract
{
	public interface ICountryService
	{
		Task<GetCountriesResponse> GetCountriesAsync(GetCountriesRequest request);
	}
}
