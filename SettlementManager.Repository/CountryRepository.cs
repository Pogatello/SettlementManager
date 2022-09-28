using Microsoft.EntityFrameworkCore;
using SettlementManager.Model;

namespace SettlementManager.Repository
{
	public class CountryRepository : ICountryRepository
	{
		#region Fields

		private readonly SettlementMangerDbContext _context;

		#endregion

		#region Constructors

		public CountryRepository(SettlementMangerDbContext context)
		{
			_context = context;
		}

		#endregion

		#region ISettlementReposiotry

		public async Task<IEnumerable<Country>> GetCountriesAsync()
		{
			return await _context.Countries.ToListAsync();
		}

		public async Task<IEnumerable<Country>> GetCountryQueryAsync(CountryQuery query)
		{
            return await _context.Countries.Where(x => x.Name.ToLower().StartsWith(query.SearchTerm.ToLower())).ToListAsync();
        }

        #endregion
    }
}
