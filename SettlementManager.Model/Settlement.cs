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

		#region Public Methods


		public void ValidateForCreate()
		{
			//Messages should be in separate class ex. SettlementBrokenRules

			if (string.IsNullOrWhiteSpace(Name))
			{
				AddBrokenRule("Name is required.");
			}

			if (string.IsNullOrWhiteSpace(PostalCode))
			{
				AddBrokenRule("Postal code is required.");
			}

			if (CountryId == default)
			{
				AddBrokenRule("Country is required");
			}

			ThrowExceptionIfThereAreBrokenRules();
		}

		public void ValidateForUpdate()
		{
			//Messages should be in separate class ex. SettlementBrokenRules
			if (Id == default)
			{
				AddBrokenRule("Id is required for update.");
			}

			ValidateForCreate();
		}

		#endregion
	}
}
