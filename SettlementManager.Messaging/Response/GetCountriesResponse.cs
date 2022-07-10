using SettlementManager.Messaging.Response.Common;
using SettlementManager.Messaging.View;

namespace SettlementManager.Messaging.Response
{
	public class GetCountriesResponse : ResponseBase
	{
		public IEnumerable<CountryView> Countries { get; set; }
	}
}
