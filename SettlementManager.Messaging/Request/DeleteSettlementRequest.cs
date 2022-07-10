using SettlementManager.Messaging.Request.Common;

namespace SettlementManager.Messaging.Request
{
	public class DeleteSettlementRequest : RequestBase
	{
		public long SettlementId { get; set; }
	}
}
