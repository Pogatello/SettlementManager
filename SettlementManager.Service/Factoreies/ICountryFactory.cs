using SettlementManager.Messaging.Response;
using SettlementManager.Model;

namespace SettlementManager.Service.Factoreies
{
	public interface ICountryFactory
	{
		GetCountriesResponse GenerateGetCountriesResponse(IEnumerable<Country> countries);

		GetCountryQueryResponse GenerateGetCountryQueryResponse(IEnumerable<Country> countries);
    }
}
