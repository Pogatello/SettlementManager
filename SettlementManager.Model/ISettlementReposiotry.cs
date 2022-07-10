namespace SettlementManager.Model
{
	public interface ISettlementReposiotry
	{
		Task<IEnumerable<Settlement>> GetSettlementsQueryAsync(SettlementQuery query);

		Task CreateSettlementAsync(Settlement settlement);

		Task UpdateSettlementAsync(Settlement settlement);
	}
}
