using AutoMapper;
using SettlementManager.Messaging.View;
using SettlementManager.Model;

namespace SettlementManager.Service.Factoreies.Mapping
{
	public class SettlementMappingProfile : Profile
	{
		public SettlementMappingProfile()
		{
			#region To Query

			CreateMap<GetSettlementQueryRequestView, SettlementQuery>();

			#endregion

			#region To Model

			CreateMap<CreateSettlementView, Settlement>()
				.ForMember(src => src.CountryId, opt => opt.MapFrom(dest => dest.CountryId));

			CreateMap<UpdateSettlementView, Settlement>()
				.ForMember(src => src.CountryId, opt => opt.MapFrom(dest => dest.CountryId));

			#endregion

			#region To View

			CreateMap<Settlement, SettlementView>();
			CreateMap<Country, CountryView>();

			#endregion
		}
	}
}
