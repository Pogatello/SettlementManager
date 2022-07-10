using Microsoft.EntityFrameworkCore;
using SettlementManager.Model;

namespace SettlementManager.Repository
{
	public class SettlementRepository : ISettlementRepository
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

		public async Task<Tuple<IEnumerable<Settlement>, int>> GetSettlementsQueryAsync(SettlementQuery query)
		{
			var totalItems = await _context.Settlements.CountAsync();
			var settlements = await _context.Settlements
											.Include(x=>x.Country)
											.Skip((query.PageNumber-1) * query.PageSize)
											.Take(query.PageSize)
											.ToListAsync();

			return new Tuple<IEnumerable<Settlement>, int>(settlements, totalItems);
		}

		public async Task CreateSettlementAsync(Settlement settlement)
		{
			_context.Settlements.Add(settlement);
			await _context.SaveChangesAsync();
		}

		public async Task UpdateSettlementAsync(Settlement settlement)
		{
			_context.Settlements.Update(settlement);
			await _context.SaveChangesAsync();
		}

		public async Task DeleteSettlementAsync(Settlement settlement)
		{
			_context.Settlements.Remove(settlement);
			await _context.SaveChangesAsync();
		}

		public async Task<Settlement> GetSettlementAsync(long id)
		{
			return await _context.Settlements
								 .Include(x=>x.Country)
								 .SingleOrDefaultAsync(x => x.Id == id);
		}

		#endregion
	}
}
