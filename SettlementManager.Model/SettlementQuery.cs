using SettlementManager.Model.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace SettlementManager.Model
{
	[NotMapped]
	public class SettlementQuery : ValidationEntity
	{
		#region Properties

		public int PageNumber { get; private set; }

		public int PageSize { get; private set; }

		#endregion

		#region Public Methods

		public void Validate()
		{
			//Messages should be in separate class ex. SettlementQueryBrokenRules
			if (PageNumber <= 0)
			{
				AddBrokenRule("Page number must be greater than 0.");
			}

			if (PageSize <= 0)
			{
				AddBrokenRule("Pagesize must have at least one element.");
			}

			if (PageSize > 15)
			{
				AddBrokenRule("Maximum number of elements per page is 15.");
			}

			ThrowExceptionIfThereAreBrokenRules();
		}

		#endregion
	}
}
