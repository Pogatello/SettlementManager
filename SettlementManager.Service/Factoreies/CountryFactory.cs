using AutoMapper;
using SettlementManager.Messaging.Response;
using SettlementManager.Messaging.View;
using SettlementManager.Model;

namespace SettlementManager.Service.Factoreies
{
	public class CountryFactory : ICountryFactory
	{

		#region Fields

		private readonly IMapper _mapper;

		#endregion

		#region Consturctors

		public CountryFactory(IMapper mapper)
		{
			_mapper = mapper;
		}

		#endregion

		#region ICountryFactory

		public GetCountriesResponse GenerateGetCountriesResponse(IEnumerable<Country> countries)
		{
			return new GetCountriesResponse
			{
				Success = true,
				Countries = _mapper.Map<IEnumerable<CountryView>>(countries)
			};
		}

		#endregion
	}
}
