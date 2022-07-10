namespace SettlementManager.Messaging.View
{
	public class SettlementView
	{
		public long Id { get; set; }

		public string Name { get; set; }

		public string PostalCode { get; set; }

		public CountryView Country { get; set; }
	}
}
