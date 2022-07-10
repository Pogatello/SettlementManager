using SettlementManager.Contract;
using SettlementManager.Messaging.Request;
using SettlementManager.Messaging.Response;
using SettlementManager.Model;
using SettlementManager.Service.Factoreies;

namespace SettlementManager.Service
{
	public class SettlementService : ISettlementService
	{

		#region Fiels

		private readonly ISettlementReposiotry _settlementRepository;
		private readonly ISettlementFactory _factory;

		#endregion

		#region Constructors

		public SettlementService(ISettlementReposiotry settlementRepository, ISettlementFactory factory)
		{
			_settlementRepository = settlementRepository;
			_factory = factory;
		}

		#endregion

		#region ISettlementService

		public async Task<GetSettlementQueryResponse> GetSettlementQueryAsync(GetSettlementsQueryRequest request)
		{
			var query = _factory.MapToGetSettlementQuery(request.Query);
			query.Validate();

			var result = await _settlementRepository.GetSettlementsQueryAsync(query);

			return _factory.GenerateGetSettlementQueryResponse(result);
		}

		public async Task<CreateSettlementResponse> CreateSettlementAsync(CreateSettlementRequest request)
		{
			var settlement = _factory.MapToSettlement(request.Settlement);
			settlement.ValidateForCreate();

			await _settlementRepository.CreateSettlementAsync(settlement);

			return _factory.GenerateCreateSettlementResponse();
		}

		public async Task<UpdateSettlementResponse> UpdateSettlementAsync(UpdateSettlementRequest request)
		{
			var settlement = _factory.MapToSettlement(request.Settlement);
			settlement.ValidateForUpdate();

			await _settlementRepository.UpdateSettlementAsync(settlement);

			return _factory.GenerateUpdateSettlementResponse();
		}

		#endregion
	}
}
