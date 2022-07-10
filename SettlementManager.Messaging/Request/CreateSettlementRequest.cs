using SettlementManager.Messaging.Request.Common;
using SettlementManager.Messaging.View;

namespace SettlementManager.Messaging.Request
{
	public class CreateSettlementRequest : RequestBase
	{
		public CreateSettlementView Settlement { get; set; }
	}
}
