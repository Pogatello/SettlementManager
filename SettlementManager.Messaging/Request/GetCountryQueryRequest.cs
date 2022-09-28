using SettlementManager.Messaging.Request.Common;

namespace SettlementManager.Messaging.Request
{
    public class GetCountryQueryRequest : RequestBase
    {
        public string SearchTerm { get; set; }
    }
}
