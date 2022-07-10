namespace SettlementManager.Model
{
	public interface ISettlementReposiotry
	{
		Task<Tuple<IEnumerable<Settlement>, int>> GetSettlementsQueryAsync(SettlementQuery query);

		Task CreateSettlementAsync(Settlement settlement);

		Task UpdateSettlementAsync(Settlement settlement);
	}
}
