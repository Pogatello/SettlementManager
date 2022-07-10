namespace SettlementManager.Infrastructure.Exceptions
{
	public class ResourceNotFoundException : Exception
	{
		public ResourceNotFoundException()
			: base("Traženi resurs nije pronađen.")
		{
		}
	}
}
