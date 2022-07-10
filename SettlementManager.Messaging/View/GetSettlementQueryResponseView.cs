namespace SettlementManager.Messaging.View
{
	public class GetSettlementQueryResponseView
	{
		public long TotalItems { get; set; }

		public IEnumerable<SettlementView> Settlements { get; set; }
	}
}
