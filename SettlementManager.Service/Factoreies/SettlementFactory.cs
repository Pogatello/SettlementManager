using AutoMapper;
using SettlementManager.Messaging.Response;
using SettlementManager.Messaging.View;
using SettlementManager.Model;

namespace SettlementManager.Service.Factoreies
{
	public class SettlementFactory : ISettlementFactory
	{
		#region Fields

		private readonly IMapper _mapper;

		#endregion

		#region Consturctors

		public SettlementFactory(IMapper mapper)
		{
			_mapper = mapper;
		}

		#endregion

		#region ISettlementFactory

		public SettlementQuery MapToGetSettlementQuery(GetSettlementQueryRequestView view)
		{
			return _mapper.Map<SettlementQuery>(view);
		}

		public GetSettlementQueryResponse GenerateGetSettlementQueryResponse(Tuple<IEnumerable<Settlement>, int> result)
		{
			return new GetSettlementQueryResponse
			{
				Success = true,
				Query = new GetSettlementQueryResponseView
				{
					Settlements = _mapper.Map<IEnumerable<SettlementView>>(result.Item1),
					TotalItems = result.Item2
				}
			};
		}

		public Settlement MapToSettlement(CreateSettlementView view)
		{
			return _mapper.Map<Settlement>(view);	
		}

		public Settlement MapToSettlement(UpdateSettlementView view)
		{
			return _mapper.Map<Settlement>(view);
		}

		public CreateSettlementResponse GenerateCreateSettlementResponse()
		{
			return new CreateSettlementResponse
			{
				Success = true
			};
		}

		public UpdateSettlementResponse GenerateUpdateSettlementResponse()
		{
			return new UpdateSettlementResponse
			{ 
				Success = true
			};
		}

		public DeleteSettlementResponse GenerateDeleteSettlementResponse()
		{
			return new DeleteSettlementResponse
			{
				Success = true
			};
		}

		#endregion
	}
}
