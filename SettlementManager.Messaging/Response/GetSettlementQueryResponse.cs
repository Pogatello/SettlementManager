using SettlementManager.Messaging.Response.Common;
using SettlementManager.Messaging.View;

namespace SettlementManager.Messaging.Response
{
	public class GetSettlementQueryResponse : ResponseBase
	{
		public GetSettlementQueryResponseView Query { get; set; }
	}
}
