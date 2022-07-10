using AutoMapper;
using SettlementManager.Messaging.View;
using SettlementManager.Model;

namespace SettlementManager.Service.Factoreies.Mapping
{
	public class CountryMappingProfile : Profile
	{
		public CountryMappingProfile()
		{
			#region ToView

			CreateMap<Country, CountryView>();

			#endregion
		}
	}
}
