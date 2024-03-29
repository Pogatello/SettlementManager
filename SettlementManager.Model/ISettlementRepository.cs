﻿namespace SettlementManager.Model
{
	public interface ISettlementRepository
	{
		Task<Tuple<IEnumerable<Settlement>, int>> GetSettlementsQueryAsync(SettlementQuery query);

		Task CreateSettlementAsync(Settlement settlement);

		Task UpdateSettlementAsync(Settlement settlement);

		Task DeleteSettlementAsync(Settlement settlement);

		Task<Settlement> GetSettlementAsync(long id);
	}
}
