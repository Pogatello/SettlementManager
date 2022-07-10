using SettlementManager.Model.Common;

namespace SettlementManager.Model
{
	public class Settlement : ValidationEntity
	{
		#region Properties

		public long Id { get; private set; }

		public string Name { get; private set; }

		public string PostalCode { get; private set; }

		#endregion

		#region Navigation Properties

		public long  CountryId { get; private set; }

		public Country Country { get; private set; }

		#endregion
	}
}
