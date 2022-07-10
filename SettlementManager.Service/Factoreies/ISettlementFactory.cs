using SettlementManager.Messaging.Response;
using SettlementManager.Messaging.View;
using SettlementManager.Model;

namespace SettlementManager.Service.Factoreies
{
	public interface ISettlementFactory
	{
		SettlementQuery MapToGetSettlementQuery(GetSettlementQueryRequestView view);

		GetSettlementQueryResponse GenerateGetSettlementQueryResponse(Tuple<IEnumerable<Settlement>, int> result);

		Settlement MapToSettlement(CreateSettlementView view);

		Settlement MapToSettlement(UpdateSettlementView view);

		CreateSettlementResponse GenerateCreateSettlementResponse();

		UpdateSettlementResponse GenerateUpdateSettlementResponse();

		DeleteSettlementResponse GenerateDeleteSettlementResponse();
	}
}
