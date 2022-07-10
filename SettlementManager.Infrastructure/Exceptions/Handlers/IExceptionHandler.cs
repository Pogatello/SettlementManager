using Microsoft.AspNetCore.Mvc;

namespace SettlementManager.Infrastructure.Exceptions.Handlers
{
	public interface IExceptionHandler
	{
		public bool CanHandle(Exception e);

		public ObjectResult Handle(Exception e);
	}
}
