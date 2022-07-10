using SettlementManager.Model;

namespace SettlementManager.Repository
{
	public class SettlementRepository : ISettlementReposiotry
	{
		#region Fields

		private readonly SettlementMangerDbContext _context;

		#endregion

		#region Constructors

		public SettlementRepository(SettlementMangerDbContext context)
		{
			_context = context;
		}

		#endregion

		#region ISettlementReposiotry

		public Task<Tuple<IEnumerable<Settlement>, int>> GetSettlementsQueryAsync(SettlementQuery query)
		{
			throw new NotImplementedException();
		}

		public Task CreateSettlementAsync(Settlement settlement)
		{
			throw new NotImplementedException();
		}

		public Task UpdateSettlementAsync(Settlement settlement)
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}
