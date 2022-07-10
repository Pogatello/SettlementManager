using SettlementManager.Messaging.Request;
using SettlementManager.Messaging.Response;

namespace SettlementManager.Contract
{
	public interface ISettlementService
	{

		Task<GetSettlementQueryResponse> GetSettlementQueryAsync(GetSettlementsQueryRequest request);

		Task<CreateSettlementResponse> CreateSettlementAsync(CreateSettlementRequest request);

		Task<UpdateSettlementResponse> UpdateSettlementAsync(UpdateSettlementRequest request);

		Task<DeleteSettlementResponse> DeleteSettlementAsync(DeleteSettlementRequest request);
	}
}
