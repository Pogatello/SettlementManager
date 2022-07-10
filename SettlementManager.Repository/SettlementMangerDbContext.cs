using Microsoft.EntityFrameworkCore;
using SettlementManager.Model;

namespace SettlementManager.Repository
{
	public class SettlementMangerDbContext : DbContext
	{
		#region Properties

		public virtual DbSet<Settlement> Settlements { get; set; }

		#endregion

		#region Constructors

		public SettlementMangerDbContext(DbContextOptions<SettlementMangerDbContext> options)
		: base(options)
		{

		}

		#endregion
	}
}
