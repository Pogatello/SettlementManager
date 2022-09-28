using SettlementManager.Contract;
using SettlementManager.Messaging.Request;
using SettlementManager.Messaging.Response;
using SettlementManager.Model;
using SettlementManager.Service.Factoreies;

namespace SettlementManager.Service
{
	public class CountryService : ICountryService
	{
		#region Fields

		private readonly ICountryRepository _countryRepository;
		private readonly ICountryFactory _factory;

		#endregion

		#region Constructors

		public CountryService(ICountryRepository countryRepository, ICountryFactory factory)
		{
			_countryRepository = countryRepository;
			_factory = factory;
		}

		#endregion

		#region ICountryService

		public async Task<GetCountriesResponse> GetCountriesAsync(GetCountriesRequest request)
		{
			var countries = await _countryRepository.GetCountriesAsync();
			return _factory.GenerateGetCountriesResponse(countries);
		}

		public async Task<GetCountryQueryResponse> GetCountryQueryAsync(GetCountryQueryRequest request)
		{
			var query = new CountryQuery(request.SearchTerm);
			query.Validate();

            var countries = await _countryRepository.GetCountryQueryAsync(query);

            return _factory.GenerateGetCountryQueryResponse(countries);
        }

        #endregion
    }
}
