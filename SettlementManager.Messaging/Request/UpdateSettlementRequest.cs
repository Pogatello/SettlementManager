using SettlementManager.Messaging.Request.Common;
using SettlementManager.Messaging.View;

namespace SettlementManager.Messaging.Request
{
	public class UpdateSettlementRequest : RequestBase
	{
		public UpdateSettlementView Settlement { get; set; }
	}
}
