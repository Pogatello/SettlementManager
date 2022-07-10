using SettlementManager.Infrastructure.Exceptions.Handlers;

namespace SettlementManager.Infrastructure.Exceptions.Factories
{
	public interface IExceptionHandlerFactory
	{
		public IExceptionHandler SelectHandler(Exception e);
	}
}
