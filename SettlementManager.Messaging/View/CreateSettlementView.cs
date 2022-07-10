using System.ComponentModel.DataAnnotations;

namespace SettlementManager.Messaging.View
{
	public class CreateSettlementView
	{
		[Required(ErrorMessage = "Name is required")]
		public string Name { get; set; }

		[Required(ErrorMessage = "PostalCode is required")]
		public string PostalCode { get; set; }

		[Required(ErrorMessage = "Country is required")]
		[Range(1,1000, ErrorMessage = "Enter a valid Country")]
		public long CountryId { get; set; }
	}
}
