﻿using SettlementManager.Infrastructure.Exceptions.Handlers;

namespace SettlementManager.Infrastructure.Exceptions.Factories
{
	public class ExceptionHandlerFactory : IExceptionHandlerFactory
	{

		#region Fields

		private readonly IEnumerable<IExceptionHandler> _handlers;

		#endregion

		#region Constructors

		public ExceptionHandlerFactory(IEnumerable<IExceptionHandler> handlers)
		{
			_handlers = handlers;
		}

		#endregion

		#region Public Methods

		public IExceptionHandler SelectHandler(Exception e)
		{
			var defaultHandler = _handlers.FirstOrDefault(x => x is DefaultExceptionHandler);
			var specificHandler = _handlers.FirstOrDefault(x => x != defaultHandler && x.CanHandle(e));

			return specificHandler ?? defaultHandler;
		}

		#endregion
	}
}
