using SettlementManager.Messaging.Request.Common;
using SettlementManager.Messaging.View;

namespace SettlementManager.Messaging.Request
{
	public class GetSettlementsQueryRequest : RequestBase
	{
		public GetSettlementQueryRequestView Query { get; set; }
	}
}
