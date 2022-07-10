namespace SettlementManager.Model
{
	public interface ICountryRepository
	{
		Task<IEnumerable<Country>> GetCountriesAsync();
	}
}
