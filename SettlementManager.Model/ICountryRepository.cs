namespace SettlementManager.Model
{
	public interface ICountryRepository
	{
		Task<IEnumerable<Country>> GetCountriesAsync();

		Task<IEnumerable<Country>> GetCountryQueryAsync(CountryQuery query);
    }
}
